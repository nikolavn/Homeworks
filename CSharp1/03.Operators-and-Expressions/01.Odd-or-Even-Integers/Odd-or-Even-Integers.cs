using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Number is Odd?: ");

        if (number%2==0)
        {
            Console.WriteLine("No.");
        }
        else
        {
            Console.WriteLine("Yes.");
        }
    }
}

