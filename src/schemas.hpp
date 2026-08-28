#pragma once
#include "memory.hpp"
#include <map>
#include <vector>
#include <string>


namespace schemas {

struct Field {
    std::string name;
    uint32_t offset;
    std::string type;
    std::string modifier;
};

struct SchemaClass {
    std::string name;
    uint64_t address;
    std::vector<Field> fields;
};

class Extractor {
public:

    Extractor(memory::Reader& reader, const memory::Module& libclient);
    std::map<std::string, SchemaClass> extract();

private:

    memory::Reader& reader_;
    memory::Module libclient_;
    uint64_t rodata_start_ = 0;
    uint64_t rodata_end_ = 0;
    uint64_t data_start_ = 0;
    uint64_t data_end_ = 0;

    void init_segments();
    std::string read_str(uint64_t addr);
    std::string guess_type(const std::string& name);
    std::string get_class_modifier(const std::string& name);
    std::string get_field_modifier(const std::string& name);
    std::vector<Field> extract_fields(uint64_t start_addr);
};

}