namespace _04.GeneratePermutations
{
    using System;

    class Startup
    {
        private static int[] p;

        static void Main()
        {
            int k = 3;

            p = InitiateIntArray(k);

            GeneratePermutations(k);
        }

        private static void GeneratePermutations(int k)
        {
            int helper = 0;

            if(k == 0)
            {
                Console.WriteLine("{0}", string.Join(" ", p));
                return;
            }

            GeneratePermutations(k - 1);

            for (int i = 0; i < k-1; i++)
            {
                helper = p[i];
                p[i] = p[k-1];
                p[k-1] = helper;

                GeneratePermutations(k-1);

                helper = p[i];
                p[i] = p[k - 1];
                p[k - 1] = helper;
            }
        }

        private static int[] InitiateIntArray(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = i + 1;
            }

            return arr;
        }

        private static void SwapIntValues(int first, int second)
        {
            int helper = first;
            first = second;
            second = helper;
        }
    }
}
