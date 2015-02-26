//Problem 19. Dates from text in Canada

//• Write a program that extracts from a given text all dates that match the format  DD.MM.YYYY .
//• Display them in the standard date format for Canada.


using System;
using System.Globalization;
using System.Text.RegularExpressions;

class DatesFromTextInCanada
{
    static void Main()
    {
        string regexDate = "[0-3][0-9].[0-1][0-9].[0-9][0-9][0-9][0-9]";
        string input = @"Microsoft announced its next generation PHP 03.03.2014 compiler 27.02.2013 today. It is based on .NET 01.5.2014 Framework 4.0 and is implemented 14.12.2034 as a dynamic 2.3.203 language in CLR";

        MatchCollection dates = Regex.Matches(input, regexDate);

        Console.WriteLine("Dates in text: ");

        foreach (var date in dates)
        {
            DateTime tempDate = DateTime.Parse(date.ToString());
            Console.WriteLine("{0}",tempDate.ToString(new CultureInfo("en-CA")));
        }

    }
}

