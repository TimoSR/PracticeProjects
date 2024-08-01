//
// Created by Archit3ct on 01/08/2024.
//
#include "IShape.h"

class Rectangle1 final : public IShape {

    private: double _width;
    private: double _height;

    public: static constexpr double MAX = 42;

        // Constructor & De-Constructor are supported
    public: Rectangle1(double width, double height) {
        _width = width;
        _height = height;
    }

    public: void test_function() {}

        // Public property getter for width
    public: double width() {
        return _width;
    }

        // Public property getter for height
    public: double height() {
        return _height;
    }

        // Implement the area function
    public: double area() override {
        return _width * _height;
    }

        // Implement the perimeter function
    public: double perimeter() override {
        return 2.0 * (_width + _height);
    }
};