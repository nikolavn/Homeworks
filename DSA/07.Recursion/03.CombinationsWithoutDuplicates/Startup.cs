namespace _03.CombinationsWithoutDuplicates
{
    using System;

    class Startup
    {
        private static int[] arr;

        static void Main(string[] args)
        {
            int n = 4, k = 2;

            arr = new int[k];

            GenerateCombinations(0, 1, n);
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
                arr[index] = counter;
                GenerateCombinations(index + 1, counter + 1, end);
            }
        }
    }
}
