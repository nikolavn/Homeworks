//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 0, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int  counter = 1;
        bool isFound = false;

        PrintArray<int>(array);

        while (!isFound&&counter<array.Length)
        {
            isFound = CompareToNeighbours(array, counter);
            counter++;
        }

        if (counter!=array.Length)
        {
            Console.WriteLine(counter-1);
        }
        else
        {
            Console.WriteLine(-1);
        }
        
    }

    private static bool CompareToNeighbours(int[] array, int index)
    {
        if (array[index] > array[index - 1] && array[index] > array[index + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
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

