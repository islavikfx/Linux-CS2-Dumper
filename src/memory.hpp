#pragma once
#include <cstdint>
#include <string>
#include <vector>
#include <optional>
#include <dirent.h>


namespace memory {

struct Module {
    std::string name;
    uint64_t start;
    uint64_t end;
    std::string path;
};


class Reader {
public:

    Reader(int pid);
    ~Reader();

    bool read(uint64_t addr, void* buffer, size_t size);
    std::vector<uint8_t> read_bytes(uint64_t addr, size_t size);

    template<typename T>
    T read(uint64_t addr) {
        T value{};
        read(addr, &value, sizeof(T));
        return value;
    }

    uint64_t read_ptr(uint64_t addr);
    uint32_t read_u32(uint64_t addr);

    std::optional<Module> find_module(const std::string& name);
    std::vector<Module> get_modules();
    static std::string find_pid(const std::string& process);
    int get_pid() const { return pid_; }

private:

    int pid_;
    int mem_fd_;
    std::vector<Module> modules_;
    void load_modules();
};

}