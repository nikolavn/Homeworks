//Write a program that counts in a given array of double values the number of occurrences of each value.
//Use Dictionary<TKey, TValue>.

//Example: array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}

//-2.5 -> 2 times

//3 -> 4 times

//4 -> 3 times

namespace _01.CountDoubles
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main()
        {
            var sampleArray = new[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            Console.WriteLine($"Original list: {string.Join(",", sampleArray)}{Environment.NewLine}");

            foreach (var entry in CountAppearances(sampleArray))
            {
                Console.WriteLine($"{entry.Key} --> {entry.Value} time(s)");
            }
        }

        private static IDictionary<double, int> CountAppearances(double[] array)
        {
            IDictionary<double, int> numberOfOccurances = new Dictionary<double, int>();

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
