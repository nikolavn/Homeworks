//Write a program that reads a sequence of integers(List<int>) ending with an empty line and sorts them in an increasing order.

namespace _03.SortIntegers
{
    using System;
    using System.Collections.Generic;

    using DataReader;

    class SortIntegers
    {
        static void Main()
        {
            List<int> numbersList = new List<int>();
            var dataReader = SampleDataReader.Create(Console.In);

            Console.WriteLine("Enter numbers: ");
            var currentNumber = dataReader.Read();

            while (!string.IsNullOrEmpty(currentNumber))
            {
                numbersList.Add(int.Parse(currentNumber));
                currentNumber = dataReader.Read();
            }

            Console.Write($"Initial array: {string.Join(",",numbersList)}{Environment.NewLine}");

            var sorted = SortIncreasing(numbersList);

            Console.Write($"Sorted array: {string.Join(",", sorted)}{Environment.NewLine}");

        }

        private static IList<int> SortIncreasing(IList<int> list)
        {
            int temp = 0;

            for (int counter = 0; counter < list.Count - 1; counter++)
            {
                for (int i = counter + 1; i < list.Count; i++)
                {
                    if (list[counter] > list[i])
                    {
                        temp = list[counter];
                        list[counter] = list[i];
                        list[i] = temp;
                    }
                }
            }

            return list;
        }
    }

}
