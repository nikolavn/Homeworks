using System;

class LongSequence
{
    static void Main()
    {
        int sequenceLength = 1000;

        for (int i = 2; i < sequenceLength+2; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i);
                if (i < sequenceLength+1)
                {
                    Console.Write(",");
                }

            }
            else
            {
                Console.Write(-i);
                if (i < sequenceLength+1)
                {
                    Console.Write(",");
                }
            }
        }
        Console.WriteLine();
    }
}

