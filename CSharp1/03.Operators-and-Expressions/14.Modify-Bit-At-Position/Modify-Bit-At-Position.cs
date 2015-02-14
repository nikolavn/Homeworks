using System;

class ModifyBitAtPosition
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit value: ");
        int newBitValue = int.Parse(Console.ReadLine());

        int result;

        if (newBitValue == 1)
        {
            int mask = 1 << position;
            result = (int)number | mask;            
        }
        else
        {
            int mask = ~(1 << position);
            result = (int)number & mask;
        }

        Console.WriteLine("\n{0} --> {1}\n",number,result);
        Console.WriteLine(Convert.ToString(number,2).PadLeft(32,'0'));
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}

