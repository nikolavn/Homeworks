//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.
//Example:

//input	    output
//256	     652

using System;

class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number to convert: ");
        decimal input = decimal.Parse(Console.ReadLine());

        Reverse(input);
    }

    private static void Reverse(decimal number)
    {
        Console.Write("\nReversed number --> ");
        while (number>1)
        {
            int lastDigit = (int)number % 10;
            Console.Write(lastDigit);
            number = number / 10;
        }
        Console.WriteLine();
    }
}

