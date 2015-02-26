//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. 
//So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9

using System;

class SubStringInText
{
    static void Main()
    {
        string testText = @"We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight.So we are drinking all the day. We will move out of it in 5 days.";
        string testSubstring = @"in";

        //Console.WriteLine("Enter text: ");
        //string text = Console.ReadLine();
        //Console.WriteLine("Enter sub-string to find in text:");
        //string subString = Console.ReadLine();

        Console.WriteLine("{0} is found {1} time(s) in the text:\n{2}", testSubstring, CountOccurances(testText, testSubstring), testText);
    }

    private static int CountOccurances(string text, string subString)
    {
        int occurances = 0,position = -1;

        while (text.IndexOf(subString,position+1) != -1)
        {
            position = text.IndexOf(subString, position+1);
            occurances++;
        }

        return occurances;
    }
}

