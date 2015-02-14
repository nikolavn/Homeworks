using System;

class DivideBy7and5
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Divides by 7 and 5?");

        if (number%35 == 0)
        {
            Console.WriteLine("Yes.");
        }
        else
        {
            Console.WriteLine("No.");
        }
    }
}

