//Problem 11. Format number

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;

class FormatNumber
{
    static void Main()
    {
        Console.WriteLine("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15}", number.ToString("D"));
        Console.WriteLine("{0,15}", number.ToString("X"));
        Console.WriteLine("{0,15}", number.ToString("P"));
        Console.WriteLine("{0,15}", number.ToString("E"));
    }
}
