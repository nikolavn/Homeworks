//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;
using System.Collections.Generic;

class BinarySearch
{
    static void Main()
    {
        int[] array = { 12, 13, 152, 312, 2, 1, 4123, 12, 7, 3, 643 };
        int k = 221, temp = 0;

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

        PrintArray<int>(array);

        int max = Array.BinarySearch(array, k);
        if (max < 0)
        {
            max = ~max;
            Console.WriteLine("The largest number <= {0} is:{1}", k, array[max-1]);
        }
        else
        {
            Console.WriteLine("The largest number <= {0} is:{1}", k, array[max]);
        }
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

