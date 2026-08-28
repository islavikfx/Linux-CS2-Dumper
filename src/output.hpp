#pragma once
#include "schemas.hpp"
#include <map>
#include <string>


namespace output {

void generate(const std::map<std::string, schemas::SchemaClass>& classes, uint64_t libclient_base, const std::string& pid);

}