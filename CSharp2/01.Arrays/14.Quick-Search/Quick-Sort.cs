//Problem 14. Quick sort

//Write a program that sorts an array of strings using the Quick sort algorithm.

using System;

class QuickSort
{
    static void Main()
    {
        //Console.WriteLine("Enter array size: ");
        //int size = int.Parse(Console.ReadLine());        
        //Console.WriteLine("Enter array: ");
        //int[] inputArray = GetIntArray(size);        
        int[] inputArray = { 5, 3, 2, 8, 7, 6, 1, 9, 4 };
        
        Console.Write("Unsorted Array: ");
        
        PrintArray(inputArray);
        
        int[] sortedArray = QuickSortArray(inputArray, 0, inputArray.Length-1);
        
        Console.Write("Sorted Array: ");
        
        PrintArray(sortedArray);
    }

    private static int Partition(int[] array, int startIndex, int endIndex, int pivotElementIndex)
    {
        int pivotElementValue = array[pivotElementIndex];
        int swapHelper = 0, mainElementIndex = 0;

        swapHelper = array[pivotElementIndex];
        array[pivotElementIndex] = array[endIndex];
        array[endIndex] = swapHelper;

        mainElementIndex = startIndex;

        for (int counter = startIndex; counter <= endIndex - 1; counter++)
        {
            if (array[counter] < pivotElementValue)
            {
                swapHelper = 0;
                swapHelper = array[counter];
                array[counter] = array[mainElementIndex];
                array[mainElementIndex] = swapHelper;

                mainElementIndex++;
            }
        }

        swapHelper = 0;
        swapHelper = array[mainElementIndex];
        array[mainElementIndex] = array[endIndex];
        array[endIndex] = swapHelper;

        return mainElementIndex;
    }

    private static int[] QuickSortArray(int[] array, int startIndex, int endIndex)
    {
        if (startIndex < endIndex)
        {
            int pivotElement = (startIndex + endIndex) / 2;

            int newPivotIndex = Partition(array, startIndex, endIndex, pivotElement);

            QuickSortArray(array, startIndex, newPivotIndex - 1);
            QuickSortArray(array, newPivotIndex + 1, endIndex);
        }

        return array;
    }

    private static void PrintArray(int[] array)
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

