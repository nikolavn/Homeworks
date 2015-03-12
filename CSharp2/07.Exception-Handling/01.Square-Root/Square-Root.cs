﻿//Problem 1. Square root

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter integer number: ");
            int number = int.Parse(Console.ReadLine());
            
            if (number<0)
            {
                throw new ArgumentException();
            }
            
            Console.WriteLine("Square root of {0} is: {1:F4}", number, Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}

