//Write a program that extracts from a given sequence of strings all elements that present in it odd number of times.Example:

//{C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}

namespace _02.ElementsMetOddNumberOfTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            var sampleArray = new[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            Console.WriteLine($"Original list: {string.Join(",", sampleArray)}{Environment.NewLine}");

            var cleanedList = RemoveNumbersRepeatedOddNumberOfTimes(sampleArray, CountAppearances(sampleArray));

            Console.WriteLine($"Cleaned list: {string.Join(",", cleanedList)}{Environment.NewLine}");
        }

        private static IList<string> RemoveNumbersRepeatedOddNumberOfTimes(string[] array, IDictionary<string, int> numberOfOccurances)
        {
            IList<string> cleanedList = new List<string>();

            for (int currentNumber = 0; currentNumber < array.Length - 1; currentNumber++)
            {
                if (numberOfOccurances[array[currentNumber]] % 2 != 0)
                {
                    cleanedList.Add(array[currentNumber]);
                }
            }

            return cleanedList.Distinct().ToList();
        }

        private static IDictionary<string, int> CountAppearances(string[] array)
        {
            IDictionary<string, int> numberOfOccurances = new Dictionary<string, int>();

            for (int currentNumber = 0; currentNumber < array.Length; currentNumber++)
            {
                if (numberOfOccurances.ContainsKey(array[currentNumber]))
                {
                    numberOfOccurances[array[currentNumber]]++;
                }
                else
                {
                    numberOfOccurances.Add(array[currentNumber], 1);
                }
            }

            return numberOfOccurances;
        }
    }
}
