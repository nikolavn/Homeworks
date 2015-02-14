using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.WriteLine("Enter end of interval: ");
            int intervalEnd = int.Parse(Console.ReadLine());

            Console.WriteLine("Numbers in interval [1..{0}]: ", intervalEnd);

            for (int i = 1; i <= intervalEnd; i++)
            {

                Console.WriteLine(i);

            }
        }
    }

