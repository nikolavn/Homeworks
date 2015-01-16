using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.WriteLine("Enter your number: ");
        long input = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter starting position 1: ");
        int positionOne = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter starting position 2: ");
        int positionTwo = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of bits: ");
        int numberOfBits = int.Parse(Console.ReadLine());

        if (positionOne+numberOfBits>32||positionTwo+numberOfBits>32)
        {
            Console.WriteLine("Out of range.");
        }
        else if ((positionOne<positionTwo)&&(positionOne + numberOfBits > positionTwo))
        {
            Console.WriteLine("Overlapping.");
        }
        else
        {
            for (int i = positionOne, j = positionTwo; i <positionOne + numberOfBits; i++, j++)
            {
                if ((((1 << i) & input) >> i) != (((1 << j) & input) >> j))
                {
                    input = (uint)(input ^ (1 << i));
                    input = (uint)(input ^ (1 << j));
                }
            }

            Console.WriteLine(input);
        }
    }
}

