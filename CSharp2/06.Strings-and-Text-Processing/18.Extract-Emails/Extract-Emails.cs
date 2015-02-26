//Problem 18. Extract e-mails

//• Write a program for extracting all email addresses from given text.
//• All sub-strings that match the format  <identifier>@<host>…<domain>  should be recognized as emails.


using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string regExEmailPatter = @"([a-z0-9_\.-]+)@([\da-z\.-]{2,})\.([a-z\.]{2,6})"; //Regex patter taken from http://net.tutsplus.com/tutorials/other/8-regular-expressions-you-should-know/. Modified to accept at least 2 symbols after "@".

        string sampleText = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";

        MatchCollection matches = Regex.Matches(sampleText, regExEmailPatter);

        Console.WriteLine("Text is: ");
        Console.WriteLine(sampleText);
        Console.WriteLine("\nIt contains following e-mails:\n");

        foreach (Match match in matches)
        {
            Console.WriteLine(match);
            Console.WriteLine();
        }
    }
}

