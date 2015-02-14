//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.
//Example:
//input	                                  result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	    2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class MaximalSum
{
    static void Main()
    {
        //Console.WriteLine("Enter array size: ");
        //int size = int.Parse(Console.ReadLine());        
        //Console.WriteLine("Enter array: ");
        //int[] array = GetIntArray(size);
        
        int[] array = { -2, -3, 6, 5, 2, -1, -6, -4, -8, 8 };
        int maxSum = int.MinValue, tempSum = 0, startElement = 0, numberOfElements = 0;

        for (int arrayCounter = 0; arrayCounter < array.Length - 1; arrayCounter++)
        {
            int elementCounter = 0;

            for (int subArrayCounter = arrayCounter + 1; subArrayCounter < array.Length; subArrayCounter++)
            {
                tempSum += array[subArrayCounter];
                elementCounter++;

                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    startElement = arrayCounter;
                    numberOfElements = elementCounter;
                }
            }

            tempSum = 0;
        }

        Console.WriteLine("Max Sum: {0}", maxSum);
        Console.Write("Elements:");
        for (int i = startElement; i < startElement + numberOfElements + 1; i++)
        {
            if (i == startElement + numberOfElements)
            {
                Console.Write(array[i]);
            }
            else
            {
                Console.Write(array[i] + ",");
            }
        }

        Console.WriteLine();
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

