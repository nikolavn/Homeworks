//Problem 16. Date difference

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        Console.WriteLine("Enter first date: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Enter second date: ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("There are {0} day(s) between {1:dd.MM.yyyy} and {2:dd.MM.yyyy}",(secondDate-firstDate).TotalDays,firstDate,secondDate);
    }
}

