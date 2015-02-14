//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest 
//from the rest, move it at the second position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        //Console.WriteLine("Enter array size: ");
        //int size = int.Parse(Console.ReadLine());        
        //Console.WriteLine("Enter array: ");
        //int[] array = GetIntArray(size);
        
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int temp = 0;

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        for (int counter = 0; counter < array.Length - 1; counter++)
        {
            for (int i = counter + 1; i < array.Length; i++)
            {
                if (array[counter] > array[i])
                {
                    temp = array[counter];
                    array[counter] = array[i];
                    array[i] = temp;
                }
            }
        }

        Console.WriteLine("Sorted array:");
        PrintArray<int>(array);
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

