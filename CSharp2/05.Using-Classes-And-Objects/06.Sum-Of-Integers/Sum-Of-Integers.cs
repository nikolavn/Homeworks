using System;

class SumOfIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter integers separated by space: ");
        string input = Console.ReadLine();
        int sum = 0;
        string[] inputAsString = input.Split(new string[] {" "} ,StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < inputAsString.Length; i++)
        {
            sum += int.Parse(inputAsString[i]);
        }

        Console.WriteLine("Sum of elements is: {0}",sum);
    }
}

