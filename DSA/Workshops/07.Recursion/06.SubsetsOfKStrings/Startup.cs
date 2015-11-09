namespace _06.SubsetsOfKStrings
{
    using System;

    class Startup
    {
        public static string[] arr;
        public static string[] set;

        static void Main()
        {
            int k = 2;

            arr = new string[k];
            set = new string[] { "test", "rock", "fun" };

            GenerateCombinations(0,0,k);
        }

        public static void GenerateCombinations(int index, int start, int end)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(",", arr));
                return;
            }

            for (int counter = start; counter <= end; counter++)
            {
                arr[index] = set[counter];
                GenerateCombinations(index + 1, counter + 1, end);
            }
        }
    }
}
