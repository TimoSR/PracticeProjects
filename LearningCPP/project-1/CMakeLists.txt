cmake_minimum_required(VERSION 3.28)
project(LearningCPP)

set(CMAKE_CXX_STANDARD 26)

add_executable(LearningCPP main.cpp
        Rectangle1.cpp
        IShape.hpp
        Rectangle2.cpp
        Rectangle2.hpp
)
