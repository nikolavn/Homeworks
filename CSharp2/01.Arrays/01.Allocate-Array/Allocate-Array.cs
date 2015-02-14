//Problem 1. Allocate array

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class AllocateArray
{
    static void Main()
    {
        int[] array = new int[20];

        for (int counter = 0; counter < array.Length; counter++)
        {
            array[counter] = counter * 5;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Element {0} --> {1}",i+1,array[i]);
        }
    }
}

