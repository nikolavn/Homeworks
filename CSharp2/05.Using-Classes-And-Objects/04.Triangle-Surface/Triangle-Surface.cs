using System;

class TriangleSurface
{
    static void Main()
    {
        int choice = 0;
        bool isValidChoice = false;

        while (!isValidChoice)
        {
            Console.WriteLine("Choose how to calculate surface:");
            Console.WriteLine("1. Using side and altitude to it");
            Console.WriteLine("2. Using 3 sides");
            Console.WriteLine("3. Using 2 sides and included angle");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1 || choice == 2 || choice == 3)
            {
                isValidChoice = true;
            }

            switch(choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Enter side: ");
                    double side = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter altitude: ");
                    double altitude = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area of triangle is: {0:F3}",SideAltitudeSurface(side,altitude));
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Enter side A: ");
                    double sideA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter side B: ");
                    double sideB = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter side C: ");
                    double sideC = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area of triangle is: {0:F3}",PerimeterSurface(sideA,sideB,sideC));
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Enter side A: ");
                    double sideOne = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter side B: ");
                    double sideTwo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter angle: ");
                    double angle = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area of triangle is: {0:F3}",SidesAngleSurface(sideOne,sideTwo,angle));
                    break;
                default:
                    Console.WriteLine("Invalid selection!");
                    break;
            }
        }
    }

    private static double SideAltitudeSurface(double side, double altitude)
    {
        double surface = (side * altitude) / 2;

        return surface;
    }

    private static double PerimeterSurface(double sideA, double sideB, double sideC)
    {
        double halfPerimeter = (sideA + sideB + sideC) / 2;
        double surface = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

        return surface;
    }

    private static double SidesAngleSurface(double sideA, double sideB, double angle)
    {
        double surface = ((sideA * sideB) / 2) * Math.Sin(Math.PI*angle/180.0);

        return surface;
    }
}

