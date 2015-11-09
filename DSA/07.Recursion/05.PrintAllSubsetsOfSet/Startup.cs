namespace _05.PrintAllSubsetsOfSet
{
    using System;

    class Startup
    {
        public static string[] arr;
        public static string[] set;

        static void Main()
        {
            int n = 3, k = 2;

            arr = new string[k];
            set = new string[] { "hi", "a", "b" };

            GenerateCombinations(0, 0);
        }

        public static void GenerateCombinations(int index, int startIndex)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(",", arr));
                return;
            }

            for (int counter = startIndex; counter < set.Length; counter++)
            {
                arr[index] = set[counter];
                GenerateCombinations(index + 1, startIndex);
            }
        }
    }
}
