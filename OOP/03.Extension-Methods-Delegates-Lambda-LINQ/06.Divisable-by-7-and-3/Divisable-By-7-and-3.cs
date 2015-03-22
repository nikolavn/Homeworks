//Problem 6. Divisible by 7 and 3

//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;

class DivisableBy7and3
{
    static void Main()
    {
        int[] intArray = new int[100];

        for (int i = 1; i <= 100; i++)
        {
            intArray[i - 1] = i;
        }

        var divisableBy7and3 = intArray.Where(x => (x % 7 == 0 && x % 3 == 0));

        foreach (var number in divisableBy7and3)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine(new string('=',25));

        var divisableBy7and3Linq =
            from num in intArray
            where num % 7 == 0 && num % 3 == 0
            select num;

        foreach (var number in divisableBy7and3Linq)
        {
            Console.WriteLine(number);
        }
    }
}

