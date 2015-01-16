using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter your number: ");
        uint input = uint.Parse(Console.ReadLine());
        
        for (int i = 3, j = 24; i < 6; i++,j++)
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

