#include "schemas.hpp"
#include <iostream>
#include <fstream>
#include <algorithm>
#include <cstring>
#include <set>


namespace schemas {

Extractor::Extractor(memory::Reader& reader, const memory::Module& libclient)
    : reader_(reader), libclient_(libclient) {
    init_segments();
}

void Extractor::init_segments() {
    std::ifstream maps("/proc/" + std::to_string(reader_.get_pid()) + "/maps");
    std::string line;

    while (std::getline(maps, line)) {
        if (line.find("libclient.so") == std::string::npos) continue;

        uint64_t start, end;
        char perms[5] = {0};
        sscanf(line.c_str(), "%lx-%lx %4s", &start, &end, perms);

        if (strcmp(perms, "r--p") == 0 && rodata_start_ == 0) {
            rodata_start_ = start;
            rodata_end_ = end;

        } else if (strcmp(perms, "rw-p") == 0 && data_start_ == 0) {
            data_start_ = start;
            data_end_ = end;
        }
    }
}

std::string Extractor::read_str(uint64_t addr) {
    if (addr < rodata_start_ || addr >= data_end_) return "";
    auto data = reader_.read_bytes(addr, 256);
    if (data.empty()) return "";
    size_t len = 0;
    while (len < data.size() && data[len] != '\0') len++;
    return std::string((char*)data.data(), len);
}


std::string Extractor::guess_type(const std::string& name) {
    if (name.rfind("__m_p", 0) == 0) return "IntPtr";
    if (name.rfind("m_b", 0) == 0) return "bool";
    if (name.rfind("m_fl", 0) == 0) return "float";
    if (name.rfind("m_db", 0) == 0) return "double";
    if (name.rfind("m_n", 0) == 0 || name.rfind("m_i", 0) == 0) return "int";
    if (name.rfind("m_h", 0) == 0) return "CHandle";
    if (name.rfind("m_vec", 0) == 0) return "Vector3";
    if (name.rfind("m_p", 0) == 0) return "IntPtr";
    if (name.rfind("m_sz", 0) == 0 || name.rfind("m_s", 0) == 0) return "string";
    if (name.rfind("m_u", 0) == 0) return "uint";
    if (name.rfind("m_ang", 0) == 0 || name.rfind("m_q", 0) == 0) return "QAngle";
    if (name.rfind("m_Color", 0) == 0 || name.rfind("m_Col", 0) == 0) return "Color";
    if (name.rfind("m_e", 0) == 0) return "int";
    return "int";
}

std::string Extractor::get_class_modifier(const std::string& name) {
    if (name.find("_API") != std::string::npos) return "external";
    if (name.find("Alias_") != std::string::npos) return "internal";
    if (name.find("::") != std::string::npos) return "internal";
    if (!name.empty() && name[0] == 'C' && name.length() > 1 && name[1] == '_') return "public";
    if (!name.empty() && name[0] == 'C' && name.length() > 1) return "public";
    return "internal";
}

std::string Extractor::get_field_modifier(const std::string& name) {
    if (name.rfind("__m_", 0) == 0) return "private";
    if (name.rfind("s_", 0) == 0) return "static";
    return "public";
}


std::vector<Field> Extractor::extract_fields(uint64_t start_addr) {
    std::vector<Field> fields;
    std::set<uint32_t> seen_offsets;

    for (int i = 0; i < 300; i++) {
        uint64_t field_addr = start_addr + (i * 0x20);
        uint64_t name_ptr = reader_.read_ptr(field_addr);

        if (name_ptr < rodata_start_ || name_ptr >= rodata_end_) break;

        std::string name = read_str(name_ptr);

        bool valid = name.rfind("m_", 0) == 0 || name.rfind("__m_", 0) == 0 || name.rfind("s_", 0) == 0;
        if (!valid) break;

        uint32_t offset = reader_.read_u32(field_addr + 0x10);
        if (offset > 0x20000) break;

        if (seen_offsets.count(offset)) continue;
        seen_offsets.insert(offset);

        Field field;
        field.name = name;
        field.offset = offset;
        field.type = guess_type(name);
        field.modifier = get_field_modifier(name);
        fields.push_back(field);
    }

    std::sort(fields.begin(), fields.end(),
    [](const Field& a, const Field& b) { return a.offset < b.offset; });

    return fields;
}


std::map<std::string, SchemaClass> Extractor::extract() {
    std::map<std::string, SchemaClass> classes;

    size_t data_size = data_end_ - data_start_;
    auto data = reader_.read_bytes(data_start_, data_size);

    if (data.empty()) {
        std::cerr << "[!] Failed to read .data.\n";
        return classes;
    }

    std::set<uint64_t> field_addrs;

    for (size_t i = 0; i < data.size() - 0x20; i += 8) {
        uint64_t name_ptr = *(uint64_t*)(data.data() + i);
        if (name_ptr >= rodata_start_ && name_ptr < rodata_end_) {
            std::string name = read_str(name_ptr);
            if (name.rfind("m_", 0) == 0 || name.rfind("__m_", 0) == 0 || name.rfind("s_", 0) == 0) {
                field_addrs.insert(data_start_ + i);
            }
        }
    }

    std::set<uint64_t> processed;

    for (uint64_t field_addr : field_addrs) {
        if (processed.count(field_addr)) continue;
        if (field_addrs.count(field_addr - 0x20)) continue;

        auto fields = extract_fields(field_addr);
        if (fields.size() < 2) continue;

        std::string class_name;
        uint64_t class_addr = field_addr;

        for (uint64_t addr = field_addr - 0x2000; addr < field_addr; addr += 8) {
            if (addr < data_start_) continue;

            uint64_t ptr = reader_.read_ptr(addr);
            if (ptr >= rodata_start_ && ptr < rodata_end_) {
                std::string name = read_str(ptr);

                if (name.length() >= 3 && name.length() < 100) {
                    if (name[0] == '#' || name[0] == ' ') continue;
                    if (name.find('.') != std::string::npos) continue;
                    if (name.find('/') != std::string::npos) continue;

                    if (name.rfind("C_", 0) == 0 ||
                        name.rfind("C", 0) == 0 ||
                        name.find("entity") != std::string::npos ||
                        name.find("player") != std::string::npos ||
                        name.find("weapon") != std::string::npos ||
                        name.find("env_") != std::string::npos ||
                        name.find("func_") != std::string::npos ||
                        name.find("info_") != std::string::npos ||
                        name.find("trigger") != std::string::npos ||
                        name.find("light") != std::string::npos ||
                        name.find("prop_") != std::string::npos) {

                        class_name = name;
                        class_addr = addr;
                        break;
                    }
                }
            }
        }

        if (class_name.empty()) continue;

        SchemaClass cls;
        cls.name = class_name;
        cls.address = class_addr;
        cls.fields = fields;

        if (classes.count(class_name) == 0 || fields.size() > classes[class_name].fields.size()) {
            classes[class_name] = cls;
        }

        for (int i = 0; i < (int)fields.size(); i++) {
            processed.insert(field_addr + (i * 0x20));
        }
    }

    return classes;
}

}