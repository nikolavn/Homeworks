using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i);
                if (i < 11)
                {
                    Console.Write(",");
                }

            }
            else
            {
                Console.Write(-i);
                if (i < 11)
                {
                    Console.Write(",");
                }
            }
        }
        Console.WriteLine();
    }
}

