//
// Created by Archit3ct on 01/08/2024.
//

#ifndef LEARNINGCPP_ISHAPE_HPP
#define LEARNINGCPP_ISHAPE_HPP

#include<print>

using namespace std;

class Interface {};

// Abstract base class to represent thzze Shape interface
class IShape : Interface {

public: virtual double area() = 0;
public: virtual double perimeter() = 0;

public: static void check_for_IShape(IShape* shape) {
        if (IShape* iShape = dynamic_cast<IShape*>(shape)) {
            println("True! Is an IShape!");
        }
    }
};

#endif //LEARNINGCPP_ISHAPE_HPP
