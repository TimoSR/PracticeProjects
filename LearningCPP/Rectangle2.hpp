//
// Created by Archit3ct on 01/08/2024.
//

#ifndef LEARNINGCPP_RECTANGLE2_HPP
#define LEARNINGCPP_RECTANGLE2_HPP


#include "IShape.hpp"

/*
    .h files, or header files, are used to list the publicly accessible instance variables
    and methods in the class declaration. .cpp files, or implementation files, are used to
    actually implement those methods and use those instance variables.

    The reason they are separate is because .h files aren't compiled into binary code while
    .cpp files are. Take a library, for example. Say you are the author and you don't want
    it to be open source. So you distribute the compiled binary library and the header files
    to your customers. That allows them to easily see all the information about your library's
    classes they can use without being able to see how you implemented those methods. They are
    more for the people using your code rather than the compiler. As was said before: it's the convention.
*/

class Rectangle2 : public IShape {

    private:
        double _width;
        double _height;

    public:
        static constexpr double MAX = 42;

        Rectangle2(double width, double height);

        double width();
        double height();

        double area() override;
        double perimeter() override;

        void test_function();

};

#endif //LEARNINGCPP_RECTANGLE2_HPP
