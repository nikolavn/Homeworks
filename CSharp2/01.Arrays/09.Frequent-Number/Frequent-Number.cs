using System;

class Number
{
    static void Main()
    {
        //Console.WriteLine("Enter array size: ");
        //int size = int.Parse(Console.ReadLine());        
        //Console.WriteLine("Enter array: ");
        //int[] array = GetIntArray(size);
        
        int[] array = { 4, 1, 1, 4, 2, 3, 1, 4, 4, 1, 2, 4, 1, 9, 3, 1 };
        int currentElement = 0, elementsCount = 1, tempCount = 1, indexOfMostFrequent = 0;

        for (int arrayCounter = 0; arrayCounter < array.Length - 1; arrayCounter++)
        {
            currentElement = array[arrayCounter];

            for (int subArrayCounter = arrayCounter + 1; subArrayCounter < array.Length; subArrayCounter++)
            {
                if (array[subArrayCounter] == currentElement)
                {
                    tempCount++;
                }

                if (tempCount > elementsCount)
                {
                    elementsCount = tempCount;
                    indexOfMostFrequent = currentElement;
                }
            }
            tempCount = 1;
        }

        PrintArray<int>(array);

        if (elementsCount==1)
        {
            Console.WriteLine("Each element appears one time.");
        }
        else
        {
            Console.WriteLine("Most frequent element: {0} ({1} times)", array[indexOfMostFrequent], elementsCount);
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

