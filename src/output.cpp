#include "output.hpp"
#include <fstream>
#include <iostream>
#include <ctime>
#include <iomanip>
#include <chrono>
#include <sstream>
#include <sys/stat.h>


namespace output {

static std::string current_time() {
    auto now = std::chrono::system_clock::now();
    std::time_t t = std::chrono::system_clock::to_time_t(now);
    std::tm* tm = std::localtime(&t);
    std::stringstream ss;
    ss << std::put_time(tm, "%Y %B %d, %I:%M%p");
    return ss.str();
}

static std::string get_class_modifier(const std::string& name) {
    if (name.find("_API") != std::string::npos) return "external";
    if (name.find("Alias_") != std::string::npos) return "internal";
    if (name.find("::") != std::string::npos) return "internal";
    if (!name.empty() && name[0] == 'C' && name.length() > 1 && name[1] == '_') return "public";
    if (!name.empty() && name[0] == 'C' && name.length() > 1) return "public";
    return "internal";
}

void generate(const std::map<std::string, schemas::SchemaClass>& classes, uint64_t libclient_base, const std::string& pid) {
    mkdir("output", 0755);

    std::ofstream out("output/libclient_dump.cs");

    out << "// # Linux Shitical-Strike 2 Dumper by @islavikfx (Beta)\n";
    out << "// # github.com/islavikfx\n";
    out << "// # MIT License\n\n";
    out << "// # " << current_time() << "\n";
    out << "// # Runtime PID: " << pid << "\n";
    out << "// # Game version: [Input]\n\n";
        out << "// # Parsed classes: " << std::dec << classes.size() << ";\n";
    out << "// # Dumping only libclient.so;\n";
    out << "return libclient_so (0x" << std::hex << libclient_base << ") {\n\n";

    for (const auto& [name, cls] : classes) {
        uint64_t rel = cls.address - libclient_base;

        out << "    // Address: 0x" << std::hex << rel << "\n";
        out << "    " << get_class_modifier(name) << " class " << name << "\n";
        out << "    {\n";
        out << "        // Fields (" << std::dec << cls.fields.size() << "):\n";

        for (const auto& field : cls.fields) {
            out << "        " << field.modifier << " readonly " << field.type
            << " " << field.name << " = 0x" << std::hex << field.offset << ";\n";
        }

        out << "    }\n\n";
    }

    out << "}\n";
    out.close();
}

}