using System;

class BinarySearch
{
    static void Main()
    {
        //Console.WriteLine("Enter array size: ");
        //int size = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter number to find: ");
        //int elementToFind = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter array: ");
        //int[] array = GetArray(size);

        int[] sortedArray = { 1, 2, 3, 4, 5, 7, 9, 11, 17, 25, 34, 42, 46 };
        int elementToFind = 34, foundAtIndex = 0;
        bool isFound = false;
        int startIndex = 0;
        int endIndex = sortedArray.Length;

        //int[] sortedArray = SortArray(array);

        while ((startIndex <= endIndex) && !isFound)
        {
            int elementIndex = (startIndex + endIndex) / 2;

            if (sortedArray[elementIndex] == elementToFind)
            {
                foundAtIndex = elementIndex;
                isFound = true;
            }
            else if (sortedArray[elementIndex] > elementToFind)
            {
                endIndex = elementIndex - 1;
            }
            else
            {
                startIndex = elementIndex + 1;
            }
        }

        PrintArray(sortedArray);

        if (foundAtIndex != 0)
        {
            Console.WriteLine("Element is found at index: {0} (position:{1})", foundAtIndex,foundAtIndex+1);
        }
        else
        {
            Console.WriteLine("Element not found!");
        }
    }

    private static int[] SortArray(int[] array)
    {
        int temp;

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

        return array;
    }

    private static void PrintArray(int[] array)
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

