using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter position: ");
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int numberAndMask = (int)number & mask;
        int bit = (int)numberAndMask >> position;

        Console.WriteLine("Bit {2} of {0} is: {1}", number, bit,position);
    }
}

