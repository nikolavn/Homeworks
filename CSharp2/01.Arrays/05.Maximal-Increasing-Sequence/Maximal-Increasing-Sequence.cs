//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input	                  |   result
//3, 2, 3, 4, 2, 2, 4	  |  2, 3, 4

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        //Console.WriteLine("Enter array size: ");
        //int size = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter first array: ");
        //int[] array = GetArray(size);
        int[] array = { 3, 2, 3, 4, 2, 3, 4, 5, 6, 2, 4 };
        int maxSequenceLength = 0, sequenceLastMemberID = 0, tempSequence = 1;

        for (int counter = 1; counter < array.Length; counter++)
        {
            if (array[counter] > array[counter - 1])
            {
                tempSequence++;
            }
            else
            {
                if (tempSequence > maxSequenceLength)
                {
                    maxSequenceLength = tempSequence;
                    sequenceLastMemberID = counter - 1;
                }
                tempSequence = 1;
            }

        }

        Console.WriteLine("Maximum sequence length: "+maxSequenceLength);
        Console.Write("Maximum sequence -> ");
        
        for (int i = sequenceLastMemberID-maxSequenceLength+1; i <= sequenceLastMemberID; i++)
        {
            if (i==sequenceLastMemberID)
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

    private static int[] GetArray(int arraySize)
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

