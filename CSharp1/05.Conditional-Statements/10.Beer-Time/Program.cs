using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter date in following format (hh:mm tt): ");
        string format = "hh:mm tt";

        TimeSpan startOfBeerTime = new TimeSpan(13, 0, 0); //represents 01:00 PM as time span object
        TimeSpan endOfBeerTime = startOfBeerTime + TimeSpan.FromHours(14); // adds 14 hours to the start time. 
                                                       //This is the total duration of beer time
        DateTime inputDate = DateTime.Now;
        //try-catch block is used to handle the format exception that would be thrown if parsing fails.
        //the try-catch block displays custom error
        try
        {
            string input = Console.ReadLine();
            inputDate = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Format");
        }        

        if ((inputDate.TimeOfDay >= startOfBeerTime) && (inputDate.TimeOfDay < endOfBeerTime))
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}

