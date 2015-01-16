using System;
using System.Globalization;
using System.Threading;
   
class Trapezoids
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        Console.WriteLine("Enter side a: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        double trapezoidArea = ((sideA + sideB) / 2) * height;

        Console.WriteLine("\nTrapezoid area is: {0}\n",trapezoidArea);
    }
}

