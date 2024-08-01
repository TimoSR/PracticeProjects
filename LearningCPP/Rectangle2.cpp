//
// Created by Archit3ct on 01/08/2024.
//

#include "Rectangle2.h"

// Constructor
Rectangle2::Rectangle2(double width, double height) : _width(width), _height(height) {}

// Getter for width
double Rectangle2::width() {
    return _width;
}

// Getter for height
double Rectangle2::height() {
    return _height;
}

// Calculate area
double Rectangle2::area() {
    return _width * _height;
}

// Calculate perimeter
double Rectangle2::perimeter() {
    return 2.0 * (_width + _height);
}

void Rectangle2::test_function() {}


#include "Rectangle2.h"
