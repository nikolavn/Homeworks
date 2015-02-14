using System;

class IntegerCalculations
{
    static void Main()
    {
        int[] numbers = { 5, 12, 3, 4, 5, 1245, 15, 23, 12, 545, 23, 36, 49 };

        Console.WriteLine(FindMinimum(numbers));
        Console.WriteLine(FindMaximum(numbers));
        Console.WriteLine(CalculateAverage(numbers));
        Console.WriteLine(CalculateSum(numbers));
        Console.WriteLine(CalculateProduct(numbers));
    }

    private static int FindMinimum(params int[] numbers)
    {
        int minimum = int.MaxValue;

        for (int counter = 0; counter < numbers.Length; counter++)
        {
            if (numbers[counter] < minimum)
            {
                minimum = numbers[counter];
            }
        }

        return minimum;
    }

    private static int FindMaximum(params int[] numbers)
    {
        int maximum = int.MinValue;

        for (int counter = 0; counter < numbers.Length; counter++)
        {
            if (numbers[counter] > maximum)
            {
                maximum = numbers[counter];
            }
        }

        return maximum;
    }

    private static double CalculateAverage(params int[] numbers)
    {
        return CalculateSum(numbers) / numbers.Length;
    }

    private static int CalculateSum(params int[] numbers)
    {
        int sum = 0;

        for (int counter = 0; counter < numbers.Length; counter++)
        {
            sum += numbers[counter];
        }

        return sum;
    }

    private static long CalculateProduct(params int[] numbers)
    {
        long product = 1;

        for (int counter = 0; counter < numbers.Length; counter++)
        {
            product *= (long)numbers[counter];
        }

        return product;
    }
}
