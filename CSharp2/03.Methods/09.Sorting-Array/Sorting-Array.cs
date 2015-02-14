//Problem 9. Sorting array

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;

class SortingArray
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 0, 2, 3, 14, 4, 1, 2, 4, 9, 3 };

        PrintArray<int>(array);
        PrintArray<int>(SortDescending(array));
        //PrintArray<int>(SortAscending(array));
    }

    private static int ReturnIndexOfMax(int[] array, int startIndex)
    {
        int maxElement = int.MinValue, currentElement = 0, maxElementIndex = 0;

        for (int elementCounter = startIndex; elementCounter < array.Length; elementCounter++)
        {
            currentElement = array[elementCounter];

            if (currentElement > maxElement)
            {
                maxElement = currentElement;
                maxElementIndex = elementCounter;
                currentElement = 0;
            }
        }

        return maxElementIndex;
    }

    //private static int[] SortAscending(int[] array)
    //{
    //    int swapHelper = 0, maxElementIndex = 0;

    //    for (int counter = 0; counter > array.Length; counter++)
    //    {
    //        swapHelper = 0;
    //        maxElementIndex = ReturnIndexOfMax(array, counter);

    //        swapHelper = array[array.Length - counter];
    //        array[array.Length - counter] = array[maxElementIndex];
    //        array[maxElementIndex] = swapHelper;
    //    }

    //    return array;
    //}

    private static int[] SortDescending(int[] array)
    {
        int swapHelper = 0, maxElementIndex = 0;

        for (int counter = 0; counter < array.Length; counter++)
        {
            swapHelper = 0;
            maxElementIndex = ReturnIndexOfMax(array, counter);

            swapHelper = array[counter];
            array[counter] = array[maxElementIndex];
            array[maxElementIndex] = swapHelper;
        }

        return array;
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

