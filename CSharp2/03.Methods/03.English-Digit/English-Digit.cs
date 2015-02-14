//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.
//Examples:

//input	    output
//512	    two
//1024	    four
//12309	    nine

using System;

class EnglishDigit
{
    static void Main()
    {
        Console.WriteLine("Enter integer number: ");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine("Last digit is: " + DigitAsWord(input));
    }

    private static string DigitAsWord(int number)
    {
        int lastDigit = number % 10;

        switch (lastDigit)
        {
            case 1: return "One";
            case 2: return "Two";
            case 3: return "Three";
            case 4: return "Four";
            case 5: return "Five";
            case 6: return "Six";
            case 7: return "Seven";
            case 8: return "Eight";
            case 9: return "Nine";
            case 0: return "Zero";
            default: return "Invalid digit!";
        }
    }
}

