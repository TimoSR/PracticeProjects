#include<print>

using namespace std;

class Interface {};

// Abstract base class to represent the Shape interface
class IShape : Interface {

    public: virtual double getArea() = 0;
    public: virtual double getPerimeter() = 0;

    public: static void checkIfIShape(IShape* shape) {
        if (IShape* iShape = dynamic_cast<IShape*>(shape)) {
            println("True! Is an IShape!");
        }
    }
};

// Concrete class to represent a Rectangle
class Rectangle : public IShape {

    private: double _width;
    private: double _height;

    public: static constexpr double MAX = 42;

    // Constructor & De-Constructor are supported
    public: Rectangle(double width, double height) {

        _width = width;
        _height = height;
    }

    // Public property getter for width
    public: double getWidth() {
        return _width;
    }

    // Public property getter for height
    public: double getHeight() {
        return _height;
    }

    // Implement the getArea function
    public: double getArea() override {
        return _width * _height;
    }

    // Implement the getPerimeter function
    public: double getPerimeter() override {
        return 2.0 * (_width + _height);
    }
};

struct Point {
    double x;
    double y;
};

int main() {

    // Create a Rectangle instance using dynamic allocation
    Rectangle* rect0 = new Rectangle(3.0, 4.0);

    // Smart Pointer, If you need reference semantics and are forced to use pointers
    auto rect1 = make_unique<Rectangle>(3.0, 4.0);

    // Stack allocation, automatic storage duration, will be automatically destroyed when it goes out of scope
    Rectangle rect2(3.0, 4.0);

    // Aggregate initialization, Stack Allocated
    Point p = {.x = 1.0, y: 2.0}; // demonstrating two different ways

    // -> means that we are requesting a method from an object on the heap
    // . means that we are requesting a method from an object on the stack

    println("Height: {1}, Width: {0}", rect0->getWidth(), rect0->getHeight());
    println("Height: {}", rect0->getHeight());
    println("Area: {}", rect0->getArea());
    println("Perimeter: {}", rect0->getPerimeter());
    println("{0}", Rectangle::MAX);

    println("{}", rect1->getArea());
    println("{}", rect1->MAX);

    println("{}", rect2.getArea());

    println("{}", p.x);

    if (typeid(*rect0) == typeid(Rectangle)) {
        println("True!");
    }

    IShape::checkIfIShape(rect0);

    delete rect0;

};