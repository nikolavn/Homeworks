//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.
//Example:

//input	                        |   result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1  |	2, 2, 2

using System;

class MaximalSequence
{
    static void Main()
    {
        //Console.WriteLine("Enter array size: ");
        //int size = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter first array: ");
        //char[] array = GetArray(size);
        
        int[] array = { 1, 1, 1, 1, 1, 2, 3, 3, 3, 2, 2, 2, 2 };
        int maxSequenceLength = 1, currentElement = array[0], maxSequenceElement = 0, tempSequenceLength = 0;

        for (int counter = 0; counter < array.Length; counter++)
        {
            if (array[counter] == currentElement)
            {
                tempSequenceLength++;
                                                
                if (counter == array.Length-1) //ensures sequence will be caught if is in the end of array
                {
                    if (tempSequenceLength > maxSequenceLength)
                    {                                               
                        maxSequenceLength = tempSequenceLength;
                        maxSequenceElement = currentElement;
                    }
                }
            }
            else
            {
                if (tempSequenceLength > maxSequenceLength)
                {
                    maxSequenceLength = tempSequenceLength;
                    maxSequenceElement = currentElement;
                }
                tempSequenceLength = 1;
                currentElement = array[counter];
            }
        }

        Console.WriteLine("Max sequence length: {0}\n", maxSequenceLength);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.Write("--> ");

        for (int k = 0; k < maxSequenceLength; k++)
        {
            Console.Write(maxSequenceElement + " ");
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

