//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

class AppearanceCount
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
        int lookFor = 14;

        PrintArray<int>(array);

        if (CountAppearances(array,lookFor)==0)
        {            
            Console.WriteLine("Number {0} not found!",lookFor);
        }
        else
        {            
            Console.WriteLine("{0} is found {1} time(s) in the array.",lookFor,CountAppearances(array,lookFor));
        }
    }

    private static int CountAppearances(int[] array, int number)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]==number)
            {
                counter++;
            }
        }

        return counter;
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

