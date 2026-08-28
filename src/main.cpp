#include "memory.hpp"
#include "schemas.hpp"
#include "output.hpp"
#include <iostream>


int main() {

    std::cout << "// Shitical-Stirke 2 Dumper for libclient.so (Beta);\n";

    std::string pid_str = memory::Reader::find_pid("libclient.so");
    if (pid_str.empty()) { }

    int pid = std::stoi(pid_str);
    std::cout << "[+] PID: " << pid << ";\n";

    memory::Reader reader(pid);

    auto libclient = reader.find_module("libclient.so");
    if (!libclient) {
        std::cerr << "[!] libclient.so not found.\n";
        return 1;
    }

    schemas::Extractor extractor(reader, *libclient);
    auto classes = extractor.extract();

    output::generate(classes, libclient->start, pid_str);

    std::cout << "[+] Saved " << classes.size() << " classes to output/libclient_dump.cs.\n";

    return 0;

}