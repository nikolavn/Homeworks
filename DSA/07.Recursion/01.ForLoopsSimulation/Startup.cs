namespace _01.ForLoopsSimulation
{
    using System;

    class Startup
    {
        static int numberOfLoops;
        static int[] loops;

        static void Main()
        {
            numberOfLoops = 3;

            loops = new int[numberOfLoops];

            GenerateLoops(0);
        }

        private static void GenerateLoops(int numberOfIterations)
        {
            if (numberOfIterations == numberOfLoops)
            {
                PrintLoops();
                return;
            }

            for (int counter = 1; counter <= numberOfLoops; counter++)
            {
                loops[numberOfIterations] = counter;
                GenerateLoops(numberOfIterations + 1);
            }
        }

        private static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
    }
}
