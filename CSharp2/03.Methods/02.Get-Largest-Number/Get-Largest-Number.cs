//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers:");
        Console.WriteLine("First:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Second:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Third:");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Largest number is: {0}",LargestNumber(LargestNumber(firstNumber,secondNumber),thirdNumber));
    }

    private static int LargestNumber(int firstNumber, int secondNumber)
    {
        if (firstNumber>secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
}

