using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter circle radius: ");
        double radius = double.Parse(Console.ReadLine());

        double circlePerimeter = 2 * Math.PI * radius;
        double circleArea = Math.PI * radius * radius;

        Console.WriteLine("Circle perimeter is: {0:F2} and area is: {1:F2}", circlePerimeter, circleArea);
    }
}

