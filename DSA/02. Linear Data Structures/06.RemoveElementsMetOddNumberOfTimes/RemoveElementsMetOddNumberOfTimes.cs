//Write a program that removes from given sequence all numbers that occur odd number of times.

//Example:
//{ 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}

namespace _06.RemoveElementsMetOddNumberOfTimes
{
    using System;
    using System.Collections.Generic;

    using DataReader;

    class RemoveElementsMetOddNumberOfTimes
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

            var cleanedList = RemoveNumbersRepeatedOddNumberOfTimes(numbersList,CountAppearances(numbersList));

            Console.WriteLine($"Non-negative list: {string.Join(",", cleanedList)}{Environment.NewLine}");
        }

        private static IList<int> RemoveNumbersRepeatedOddNumberOfTimes(IList<int>numbersList,IDictionary<int,int> numberOfOccurances)
        {
            IList<int> cleanedList = numbersList;

            for (int currentNumber = 0; currentNumber < cleanedList.Count; currentNumber++)
            {
                if (numberOfOccurances[cleanedList[currentNumber]] % 2 != 0)
                {
                    cleanedList.Remove(cleanedList[currentNumber]);
                    currentNumber = 0;
                }
            }

            return cleanedList;
        }

        private static IDictionary<int,int> CountAppearances(IList<int> list)
        {
            IDictionary<int, int> numberOfOccurances = new Dictionary<int, int>();

            for (int currentNumber = 0; currentNumber < list.Count; currentNumber++)
            {
                if (numberOfOccurances.ContainsKey(list[currentNumber]))
                {
                    numberOfOccurances[list[currentNumber]]++;
                }
                else
                {
                    numberOfOccurances.Add(list[currentNumber], 1);
                }
            }

            return numberOfOccurances;
        }
    }
}
