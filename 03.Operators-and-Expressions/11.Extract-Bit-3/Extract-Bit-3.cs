using System;

class ExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        int position = 3;

        int mask = 1 << position;
        int numberAndMask = (int)number & mask;
        int bit = (int)numberAndMask >> position;

        Console.WriteLine("Bit 3 of {0} is: {1}",number,bit);
    }
}

