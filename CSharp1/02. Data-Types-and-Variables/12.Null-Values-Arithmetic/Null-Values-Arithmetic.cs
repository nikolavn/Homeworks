using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;

        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);

        nullInt += 5;
        nullDouble += 7.743;

        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);

        nullInt = 5;
        nullDouble = 7.743;

        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);
    }
}

