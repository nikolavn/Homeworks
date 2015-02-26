//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.
//Example:

//input	    output
//sample	elpmas

using System;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter word to reverse: ");
        string word = Console.ReadLine();

        Console.WriteLine("{0} reversed is: {1}", word, Reverse(word));
    }

    private static string Reverse(string input)
    {
        string output = String.Empty;

        if (String.IsNullOrEmpty(input))
        {
            Console.WriteLine("String is null or empty.");
        }
        else
        {
            for (int i = 0; i < input.Length; i++)
            {
                output += input[input.Length - 1 - i];
            }
        }

        return output;
    }
}

