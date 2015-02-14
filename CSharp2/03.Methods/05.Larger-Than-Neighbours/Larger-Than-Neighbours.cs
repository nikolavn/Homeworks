//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;

class LargerThanNeighbours
{
    static void Main()
    {
        //Console.WriteLine("Enter array size: ");
        //int size = int.Parse(Console.ReadLine());        
        //Console.WriteLine("Enter array: ");
        //int[] array = GetIntArray(size);
        //Console.WriteLine("Enter number to search for: ");
        //int numberToFind = int.Parse(Console.ReadLine());

        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int elementAtIndex = 3;

        PrintArray<int>(array);

        CompareToNeighbours(array, elementAtIndex);
    }

    private static void CompareToNeighbours(int[] array,int index)
    {
        if (index < 0 || index > array.Length)
        {
            Console.WriteLine("Element is outside array!");
            return;
        }

        if (index==1||index==array.Length-1)
        {
            Console.WriteLine("Element doesn\'t have 2 neighbours!");
            return;
        }

        if (array[index]>array[index-1]&&array[index]>array[index+1])
        {
            Console.WriteLine("Element {0} is bigger than both neighbours {1} and {2}",array[index],array[index-1],array[index+1]);
        }
        else
        {
            Console.WriteLine("Element {0} is smaller than one or both neighbours {1} and {2}",array[index],array[index-1],array[index+1]);
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

