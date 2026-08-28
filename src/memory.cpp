#include "memory.hpp"
#include <iostream>
#include <fstream>
#include <algorithm>
#include <cstring>
#include <unistd.h>
#include <fcntl.h>


namespace memory {

Reader::Reader(int pid) : pid_(pid), mem_fd_(-1) {
    std::string path = "/proc/" + std::to_string(pid_) + "/mem";
    mem_fd_ = open(path.c_str(), O_RDONLY);
    load_modules();
}

Reader::~Reader() {
    if (mem_fd_ != -1) close(mem_fd_);
}

bool Reader::read(uint64_t addr, void* buffer, size_t size) {
    if (mem_fd_ == -1) return false;
    return pread(mem_fd_, buffer, size, addr) == (ssize_t)size;
}

std::vector<uint8_t> Reader::read_bytes(uint64_t addr, size_t size) {
    std::vector<uint8_t> buf(size);
    if (!read(addr, buf.data(), size)) return {};
    return buf;
}

uint64_t Reader::read_ptr(uint64_t addr) {
    return read<uint64_t>(addr);
}

uint32_t Reader::read_u32(uint64_t addr) {
    return read<uint32_t>(addr);
}

void Reader::load_modules() {
    std::ifstream maps("/proc/" + std::to_string(pid_) + "/maps");
    std::string line;

    while (std::getline(maps, line)) {
        if (line.find("libclient.so") == std::string::npos) continue;

        size_t dash = line.find('-');
        size_t space = line.find(' ', dash);
        if (dash == std::string::npos || space == std::string::npos) continue;

        uint64_t start = std::stoull(line.substr(0, dash), nullptr, 16);
        uint64_t end = std::stoull(line.substr(dash + 1, space - dash - 1), nullptr, 16);

        auto it = std::find_if(modules_.begin(), modules_.end(),
            [](const Module& m) { return m.name == "libclient.so"; });

        if (it == modules_.end()) {
            Module mod;
            mod.name = "libclient.so";
            mod.start = start;
            mod.end = end;
            size_t path_pos = line.find('/');
            mod.path = (path_pos != std::string::npos) ? line.substr(path_pos) : "";
            modules_.push_back(mod);

        } else {
            it->start = std::min(it->start, start);
            it->end = std::max(it->end, end);
        }
    }

}


std::optional<Module> Reader::find_module(const std::string& name) {
    for (const auto& mod : modules_) {
        if (mod.name == name) return mod;
    }
    return std::nullopt;
}

std::vector<Module> Reader::get_modules() {
    return modules_;
}

std::string Reader::find_pid(const std::string& process) {
    DIR* dir = opendir("/proc");
    if (!dir) return "";

    struct dirent* entry;
    while ((entry = readdir(dir)) != nullptr) {
        if (entry->d_name[0] < '0' || entry->d_name[0] > '9') continue;

        std::ifstream maps("/proc/" + std::string(entry->d_name) + "/maps");
        std::string line;

        while (std::getline(maps, line)) {
            if (line.find(process) != std::string::npos) {
                closedir(dir);
                return entry->d_name;
            }
        }
    }

    closedir(dir);
    return "";
}

}