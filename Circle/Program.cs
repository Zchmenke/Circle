using System;

// Henrik Rydén SUT22
//Labb 1 Grunderna i OOP.

namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calling the methods from circle class to calculate the area/Circumference/spherearea based on the objects input value (radie).
            Circle radie = new Circle(5);             
            radie.GetAreaOfCircle();
            radie.GetCircomference();
            radie.GetSphere();
           // Same as above but based on another object of the circle class.
            Circle radie2 = new Circle(6);            
            radie2.GetAreaOfCircle();
            radie2.GetCircomference();
            radie2.GetSphere();

            //calling method from triangle class to calculate the area of a triangle.
            Triangle tri1 = new Triangle(4f, 8f);
            tri1.GetTriangleArea();

            Triangle tri2 = new Triangle(7f, 10f);
            tri2.GetTriangleArea();
        }
    }
}
