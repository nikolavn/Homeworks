//Problem 17. Longest string

//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string sample = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                    Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
                    Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
                    Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        string[] stringArray = sample.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

        var longestString =
            from w in stringArray
            orderby w.Length descending
            select w;

        Console.WriteLine("Longest word is: {0}", longestString.ToList()[0]);
    }
}

