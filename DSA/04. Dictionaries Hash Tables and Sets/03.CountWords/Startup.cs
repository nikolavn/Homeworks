namespace _03.CountWords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class Startup
    {
        static void Main()
        {
            var builder = new StringBuilder();

            using (var reader = new StreamReader("..\\..\\words.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    builder.Append(line);
                }
            }

            var text = builder.ToString();
            var splitText = Regex.Split(text, @"\W").Where(item => !string.IsNullOrWhiteSpace(item)).ToArray();

            var dictionary = CountAppearances(splitText).OrderBy(x => x.Value);

            foreach (var entry in dictionary)
            {
                Console.WriteLine($"{entry.Key} --> {entry.Value} time(s)");
            }
        }

        private static IDictionary<string, int> CountAppearances(string[] array)
        {
            IDictionary<string, int> numberOfOccurances = new Dictionary<string, int>();

            for (int currentWord = 0; currentWord < array.Length; currentWord++)
            {
                if (numberOfOccurances.ContainsKey(array[currentWord].ToLower()))
                {
                    numberOfOccurances[array[currentWord].ToLower()]++;
                }
                else
                {
                    numberOfOccurances.Add(array[currentWord].ToLower(), 1);
                }
            }

            return numberOfOccurances;
        }
    }
}
