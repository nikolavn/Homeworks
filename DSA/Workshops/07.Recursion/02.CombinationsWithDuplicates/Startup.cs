namespace _02.CombinationsWithDuplicates
{
    using System;

    class Startup
    {
        private static int[] arr;

        static void Main()
        {
            int n = 3, k = 2;

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
                GenerateCombinations(index + 1, start, end);
            }
        }
    }
}
