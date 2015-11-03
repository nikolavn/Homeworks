//Write a program that removes from given sequence all negative numbers.

namespace _05.RemoveNegatives
{
    using System;
    using System.Collections.Generic;

    using DataReader;

    class RemoveNagatives
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

            Console.WriteLine($"Original list: {string.Join(",", numbersList)}{Environment.NewLine}");

            var negativesRemoved = RemoveNegatives(numbersList);

            Console.WriteLine($"Non-negative list: {string.Join(",", negativesRemoved)}{Environment.NewLine}");
        }

        private static IList<int> RemoveNegatives(IList<int> list)
        {
            IList<int> nonNegativeList = list;

            for (int i = 0; i < nonNegativeList.Count; i++)
            {
                if (nonNegativeList[i] < 0)
                {
                    nonNegativeList.Remove(list[i]);
                }
            }

            return nonNegativeList;
        }
    }
}
