//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortByStringLength
{
    static void Main()
    {
        //Console.WriteLine("Enter words separated by \" \"(space):");
        //string userInput = Console.ReadLine();
        string userInput = "Write a program that finds the longest sequence of equal strings in the matrix";

        Console.WriteLine("Input string:\n");
        Console.WriteLine(userInput);

        string[] inputAsString = userInput.Split();

        //string minElement = null;
        int minElementIndex = 0;
        string swapHelper = null;

        for (int i = 0; i < inputAsString.Length - 1; i++)
        {
            minElementIndex = i;
            for (int j = i + 1; j < inputAsString.Length; j++)
            {
                if (inputAsString[j].Length < inputAsString[minElementIndex].Length)
                {
                    minElementIndex = j;
                }
            }

            if (minElementIndex != i)
            {
                swapHelper = inputAsString[i];
                inputAsString[i] = inputAsString[minElementIndex];
                inputAsString[minElementIndex] = swapHelper;
            }
        }

        Console.WriteLine("\nSorted by word length:");
        PrintArray<string>(inputAsString);
        
    }

    private static void PrintArray<T>(T[] array)
    {
        Console.Write("\n[");
        for (int counter = 0; counter < array.Length; counter++)
        {
            if (counter == array.Length - 1)
            {
                Console.Write(array[counter]);
            }
            else
            {
                Console.Write(array[counter] + ",");
            }
        }
        Console.WriteLine("]\n");
    }
}

