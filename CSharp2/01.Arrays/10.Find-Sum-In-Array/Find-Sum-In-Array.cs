//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:

//array	                 S	    result
//4, 3, 1, 4, 2, 5, 8	 11	    4, 2, 5

using System;

class FindSumInArray
{
    static void Main()
    {
        //Console.WriteLine("Enter array size: ");
        //int size = int.Parse(Console.ReadLine());        
        //Console.WriteLine("Enter array: ");
        //int[] array = GetIntArray(size);
        //Console.WriteLine("Enter sum to find: ");
        //int targetSum = int.Parse(Console.ReadLine());
        
        int targetSum = 11;
        int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        int tempSum = 0, element = 0, numberOfElems = 0;
        bool containsSum = false;

        for (int arrayCounter = 0; arrayCounter < array.Length - 1; arrayCounter++)
        {
            int elementCounter = 0;

            for (int subArrayCounter = arrayCounter + 1; subArrayCounter < array.Length; subArrayCounter++)
            {
                tempSum += array[subArrayCounter];
                elementCounter++;
                if (tempSum == targetSum)
                {
                    containsSum = true;
                    element = arrayCounter;
                    numberOfElems = elementCounter;
                }
            }

            tempSum = 0;

        }
        Console.Write("Input Array: ");
        PrintArray<int>(array);
        Console.WriteLine("Found Sum? " + containsSum);

        Console.Write("Elements: ");
        
        for (int i = (element + 1); i < element + numberOfElems + 1; i++)
        {
            if (i == element + numberOfElems)
            {
                Console.Write(array[i]+"\n");
            }
            else
            {
                Console.Write(array[i] + ",");
            }
        }
        Console.WriteLine();
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

    private static int[] GetIntArray(int arraySize)
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

