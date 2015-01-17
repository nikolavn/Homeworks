using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter  numbers: ");
        string numbers = Console.ReadLine();

        string[] numbersArray = numbers.Split(' ');

        double sum = 0;
        for (int i = 0; i < numbersArray.Length; i++)
        {

            sum += double.Parse(numbersArray[i]);

        }

        Console.WriteLine("Sum of numbers is: {0}", sum);
    }
}

