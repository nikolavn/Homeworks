//Problem 13.* Merge sort

//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;

class MergeSort
{
    static void Main()
    {
        //Console.WriteLine("Enter array size: ");
        //int size = int.Parse(Console.ReadLine());        
        //Console.WriteLine("Enter array: ");
        //int[] inputArray = GetIntArray(size);        
        int[] inputArray = { 5, 3, 2, 8, 7, 6, 1, 9, 4 };
        int[] sortedArray = new int[inputArray.Length];

        Console.Write("Unsorted Array: ");

        PrintArray(inputArray);

        SplitArray(inputArray, 0, inputArray.Length, sortedArray);

        Console.Write("Sorted Array: ");

        PrintArray(sortedArray);
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

    private static int[] CopyArray(int[] newArray, int startElement, int endElement, int[] initialArray)
    {
        for (int counter = startElement; counter < endElement; counter++)
        {
            newArray[counter] = initialArray[counter];
        }

        return newArray;
    }

    private static int[] SplitArray(int[] initialArray, int startElement, int endElement, int[] newArray)
    {
        if (endElement - startElement < 2)
        {
            return initialArray;
        }

        int middleElement = (startElement + endElement) / 2;

        SplitArray(initialArray, startElement, middleElement, newArray);
        SplitArray(initialArray, middleElement, endElement, newArray);
        MergeSubArrays(initialArray, startElement, middleElement, endElement, newArray);
        CopyArray(newArray, startElement, endElement, initialArray);

        return newArray;
    }

    private static void MergeSubArrays(int[] initialArray, int startElement, int middleElement, int endElement, int[] newArray)
    {
        for (int counter = startElement; counter < endElement; counter++)
        {
            if (startElement < middleElement - 1 && (middleElement >= endElement - 1 ||
                (initialArray[startElement] <= initialArray[middleElement])))
            {
                newArray[counter] = initialArray[startElement];
                startElement++;
            }
            else
            {
                newArray[counter] = initialArray[middleElement];
                middleElement++;
            }
        }
    }
}

