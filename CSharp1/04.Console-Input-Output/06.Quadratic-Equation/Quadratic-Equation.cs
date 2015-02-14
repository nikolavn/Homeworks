using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the coeficients of the quadratic equation.\n");

        Console.WriteLine("Enter \"a\" the coeficient in front of x^2:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter \"b\" the coeficient in front of x:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter \"c\" the coeficient in front of the free member:");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("The equation has one root: x= {0:F3}", -c / b);
        }
        else
        {
            if ((b == 0) && ((c < 0 && a > 0) || (a < 0 && c > 0)))
            {
                Console.WriteLine("The equation has 2 roots: x1= {0:F3} and x2= -{0:F3}", Math.Sqrt(-(c / a)));
            }
            else
            {
                if (b == 0 && c == 0) { Console.WriteLine("The Equation has one root: x=0"); }
                else
                {
                    if (c == 0) { Console.WriteLine("The equation has 2 roots: x1= 0 and x2= {0:F3}", -b / a); }
                    else
                    {
                        double discriminant = b * b - 4 * a * c;
                        if (discriminant < 0) { Console.WriteLine("The equation doesn't have real roots"); }
                        else
                        {
                            if (discriminant == 0) { Console.WriteLine("The equation has only one root: x= {0:F3}", -b / 2 * a); }
                            else
                            {
                                double root1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                                double root2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                                Console.WriteLine("The roots of the equation are: x1= {0:F3} and x2= {1:F3}", root1, root2);
                            }
                        }
                    }
                }
            }
        }
    }
}

