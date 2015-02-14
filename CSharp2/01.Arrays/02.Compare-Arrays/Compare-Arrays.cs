//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter array size: ");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter first array: ");
        int[] firstArrayToCompare = GetArray(size);
        Console.WriteLine("Enter second array: ");
        int[] secondArrayToCompare = GetArray(size);
        bool areEqual = true;

        for (int i = 0; i < size; i++)
        {
            if (firstArrayToCompare[i]!=secondArrayToCompare[i])
            {
                areEqual = false;
            }            
        }

        Console.WriteLine(areEqual ? "Arrays are equal." : "Arrays are not equal.");
    }

    private static int[] GetArray(int arraySize)
    {
        int number;
        int[] output = new int[arraySize];

        for (int counter = 0; counter < arraySize; counter++)
        {
            if (int.TryParse(Console.ReadLine(),out number))
            {
                output[counter] = number;
            }            
        }

        return output;
    }
}

