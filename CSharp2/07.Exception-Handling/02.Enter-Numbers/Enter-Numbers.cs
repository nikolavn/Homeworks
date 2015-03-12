//Problem 2. Enter numbers

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class EnterNumbers
{
    static void Main()
    {
        int rangeStart = 1;
        int rangeEnd = 100;
        int countOfNumbers = 10;
        
        try
        {
            while (countOfNumbers>0)
            {
                Console.WriteLine("Enter number in range [{0}, {1}]: ",rangeStart, rangeEnd);

                rangeStart = ReadNumber(rangeStart, rangeEnd);
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Number is out of the range [{0}, {1}]",rangeStart,rangeEnd);
        }
        catch(ArgumentException)
        {
            Console.WriteLine("Entry is not a number");
        }
    }

    private static int ReadNumber(int rangeStart, int rangeEnd)
    {
        int number = 0;

        bool isNumber = int.TryParse(Console.ReadLine(), out number);     

        if (!isNumber)
        {
            throw new ArgumentException();  
        }

        if (number < rangeStart || number > rangeEnd)
            {
                throw new ArgumentOutOfRangeException();
            }

        return number;
    }
}

