using System;

class Recatangles
{
    static void Main()
    {
        Console.WriteLine("Enter width: ");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (height + width);
        double area = height * width;

        Console.WriteLine("Rectangle perimter is: {0} and area is: {1}.",perimeter,area);
    }
}

