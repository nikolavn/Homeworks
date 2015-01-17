using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter count of numbers: ");
        int countOfNumbers = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 0; i < countOfNumbers; i++)
        {

            sum += double.Parse(Console.ReadLine());

        }

        Console.WriteLine("Sum of numbers is: {0}",sum);
    }
}

