//Problem 10. N Factorial

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Collections.Generic;
using System.Numerics;

class FactorialN
{
    static void Main()
    {
        bool isValidInput = false;
        BigInteger number = 0;
        BigInteger result = 0;

        while (!isValidInput)
        {
            Console.WriteLine("Enter number (0 < number <= 100): ");
            number = BigInteger.Parse(Console.ReadLine());

            if (number > 0 && number <= 100)
            {
                isValidInput = true;
            }
        }

        result = CalculateFactorial(number);

        Console.WriteLine("{0}! = {1}", number, result);
    }

    private static BigInteger CalculateFactorial(BigInteger number)
    {
        if (number < 1)
        {
            return 1;
        }

        return number*CalculateFactorial(number - 1);
    }
}

