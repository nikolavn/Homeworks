//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximalKSum
{
    static void Main()
    {
        //Console.WriteLine("Enter array size: ");
        //int size = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter number of elements: ");
        //int numberOfElements = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter array: ");
        //int[] array = GetArray(size);

        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int numberOfElements = 3, tempSum = 0, maxSum = 0, sequenceFirstElement = 0;

        for (int arrayCounter = 0; arrayCounter <= array.Length - numberOfElements; arrayCounter++)
        {
            for (int elementsCounter = 0; elementsCounter < numberOfElements; elementsCounter++)
            {
                tempSum += array[arrayCounter + elementsCounter];
            }          
            
            if (tempSum > maxSum)
            {
                maxSum = tempSum;
                sequenceFirstElement = arrayCounter;
            }

            tempSum = 0;
        }

        Console.WriteLine("Input array:");
        PrintArray(array);
        Console.WriteLine("Max sum:" + maxSum);
        Console.Write("Elements in sequence -> ");
        
        for (int i = sequenceFirstElement; i < sequenceFirstElement + numberOfElements; i++)
        {
            if (i == (sequenceFirstElement + numberOfElements)-1)
            {
                Console.Write(array[i]);
            }
            else
            {
                Console.Write(array[i] + ",");
            }       
        }
        Console.WriteLine();
    }

    private static void PrintArray(int[] array)
    {
        Console.Write("\n[");
        for (int counter = 0; counter < array.Length; counter++)
        {
            if (counter == array.Length-1)
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

    private static int[] GetArray(int arraySize)
    {
        int number;
        int[] output = new int[arraySize];

        for (int counter = 0; counter < arraySize; counter++)
        {
            if (int.TryParse(Console.ReadLine(), out number))
            {
                output[counter] = number;
            }
        }

        return output;
    }
}

