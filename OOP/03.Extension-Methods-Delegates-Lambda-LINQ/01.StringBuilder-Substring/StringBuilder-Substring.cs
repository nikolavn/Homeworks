//Problem 1. StringBuilder.Substring

//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
//and has the same functionality as Substring in the class String.

using System;
using System.Text;

class StringBuilderSubstring
{
    static void Main()
    {
        StringBuilder input = new StringBuilder();

        input.Append("Telerik");
        input.Append("Academy");

        Console.WriteLine(input.Substring(3,5).ToString());
    }
}

