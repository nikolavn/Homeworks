//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:

//input	        output
//Hi!	    \u0048\u0069\u0021

using System;

class UnicodeCharacters
{
    static void Main()
    {
        string text = @"Microsoft!";
        int temp = 0;

        for (int counter = 0; counter < text.Length; counter++)
        {
            temp = (int)text[counter];
            Console.Write("\\u{0}", temp.ToString("X4"));
        }
    }
}

