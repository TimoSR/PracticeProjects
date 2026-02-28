#include<print>
#include "Rectangle1.cpp"
#include "Rectangle2.hpp"

using namespace std;

struct Point {
    double x;
    double y;
};

int main() {

    // Create a Rectangle instance using dynamic allocation
    Rectangle1* rect0 = new Rectangle1(3.0, 4.0);

    // Smart Pointer, If you need reference semantics and are forced to use pointers
    auto rect1 = make_unique<Rectangle2>(3.0, 4.0);

    // Stack allocation, automatic storage duration, will be automatically destroyed when it goes out of scope
    Rectangle2 rect2(3.0, 4.0);

    // Aggregate initialization, Stack Allocated
    Point p = {.x = 1.0, y : 2.0}; // demonstrating two different ways

    println("Height: {1}, Width: {0}", rect0->width(), rect0->height());
    println("Height: {}", rect0->height());
    println("Area: {}", rect0->area());
    println("Perimeter: {}", rect0->perimeter());
    println("{0}", Rectangle1::MAX);

    // -> means that we are requesting a method from an object on the heap
    // . means that we are requesting a method from an object on the stack

    println("{}", rect1->area());
    println("{}", rect1->MAX);

    println("{}", rect2.area());

    println("{}", p.x);

    if (typeid(*rect0) == typeid(Rectangle1)) {
        println("True!");
    }

    float a = 0;

    println("lol {0}", typeid(a).name());

    IShape::check_for_IShape(rect0);

    delete rect0;
};