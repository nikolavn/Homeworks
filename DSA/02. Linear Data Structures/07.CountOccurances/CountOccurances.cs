//Write a program that finds in given array of integers(all belonging to the range[0..1000]) how many times each of them occurs.

//Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
//2 → 2 times
//3 → 4 times
//4 → 3 times

namespace _07.CountOccurances
{
    using System;
    using System.Collections.Generic;

    using DataReader;

    class CountOccurances
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

            foreach (var entry in CountAppearances(numbersList))
            {
                Console.WriteLine($"{entry.Key} --> {entry.Value} time(s)");
            }
        }

        private static IDictionary<int, int> CountAppearances(IList<int> list)
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
