//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter array size: ");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter first array: ");
        char[] firstArrayToCompare = GetArray(size);
        Console.WriteLine("Enter second array: ");
        char[] secondArrayToCompare = GetArray(size);
        bool areEqual = true;

        for (int i = 0; i < size; i++)
        {
            if (firstArrayToCompare[i].CompareTo(secondArrayToCompare[i])!=0)
            {
                areEqual = false;
            }
        }

        Console.WriteLine(areEqual ? "Arrays are equal." : "Arrays are not equal.");
    }

    private static char[] GetArray(int arraySize)
    {        
        char[] output = new char[arraySize];

        for (int counter = 0; counter < arraySize; counter++)
        {            
            output[counter] = Convert.ToChar(Console.ReadLine());            
        }

        return output;
    }
}

