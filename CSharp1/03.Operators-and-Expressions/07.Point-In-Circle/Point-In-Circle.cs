using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter X coordinate: ");
        double xCoord = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Y coordinate: ");
        double yCoord = double.Parse(Console.ReadLine());

        double circleRadius = 2;
        double distanceFromCenre = Math.Sqrt((xCoord * xCoord) + (yCoord * yCoord));

        if (distanceFromCenre<circleRadius)
        {
            Console.WriteLine("\nPoint is within circle.\n");
        }
        else
        {
            Console.WriteLine("\nPoint is outside circle.\n");
        }
    }
}

