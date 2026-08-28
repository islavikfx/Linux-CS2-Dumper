cmake_minimum_required(VERSION 3.28.3)
project(CS2DumperBeta VERSION 1.2.3 LANGUAGES C CXX)

set(CMAKE_CXX_STANDARD 20)
set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_CXX_EXTENSIONS OFF)
set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -Wall -Wextra -Wpedantic")
set(CMAKE_EXE_LINKER_FLAGS_RELEASE "-flto -s")
set(CMAKE_SYSTEM_NAME Linux)
set(CMAKE_BUILD_TYPE Release)

if(MSVC OR MINGW OR CYGWIN)
    message(FATAL_ERROR "Install Linux.")
endif()

file(GLOB_RECURSE SOURCES 
"src/*.cpp"
"src/*.c")

add_executable(CS2DumperBeta ${SOURCES})
target_include_directories(CS2DumperBeta PRIVATE src)
target_link_libraries(CS2DumperBeta pthread)