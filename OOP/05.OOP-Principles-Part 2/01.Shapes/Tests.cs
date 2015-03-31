//Problem 1. Shapes

//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
//    (height * width for rectangle and height * width/2 for triangle).
//Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
//Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.

using System;

class Tests
{
    static void Main()
    {
        Shape[] shapes = new Shape[] 
        {
            new Rectangle(5,6),
            new Triangle(5,6),
            new Square(6),
            new Triangle(12,4.5),
            new Rectangle(5.6,9.34),
            new Square(6.7)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine("{0} area is: {1}",shape.GetType(),shape.CalculateSurface());
        }
    }
}

