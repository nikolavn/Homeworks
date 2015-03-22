using System;
using System.Collections.Generic;

class IEnumarableExtensions
{
    static void Main()
    {
        var collection = new List<int> { 100, 200, 129783, 12329083, 9831203 };

        Console.WriteLine(collection.Sum<int>());
        Console.WriteLine(collection.Average<int>());
        Console.WriteLine(collection.Product<int>());
        Console.WriteLine(collection.Min<int>());
    }    
}

