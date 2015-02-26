//Problem 5. Workdays

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

class Workdays
{
    static void Main()
    {
        Console.WriteLine("Enter date as dd.mm.yyyy: ");
        DateTime endDate = DateTime.Today;
        bool isDate = false, isValidDate = false;        

        while (!isDate&&!isValidDate)
        {
            Console.WriteLine("Enter date as dd.mm.yyyy: ");
            isDate = DateTime.TryParse(Console.ReadLine(), out endDate);
            isValidDate = endDate.CompareTo(DateTime.Today) <= 1;
        }

        Console.WriteLine("There are {0} working days between today and {1}",CalculateWorkingDays(endDate),endDate.Date.ToString("dd.MM.yyyy"));

    }

    private static int CalculateWorkingDays(DateTime targetDate)
    {
        DateTime[] holidays = { new DateTime(2015, 3, 2), new DateTime(2015, 3, 3), new DateTime(2015, 4, 10), new DateTime(2015, 4, 11),
                                new DateTime(2015,4,12),new DateTime(2015,4,13),new DateTime(2015,5,1),new DateTime(2015,5,6),
                                new DateTime(2015,9,21),new DateTime(2015,9,22),new DateTime(2015,12,24),new DateTime(2015,12,25),
                                new DateTime(2015,12,26),new DateTime(2015,12,31)
                              };

        DateTime today = DateTime.Today;
        int workingDays = 0;
        bool isHoliday = false;

        while (today<targetDate)
        {
            for (int i = 0; i < holidays.Length; i++)
            {
                if (today == holidays[i])
                {
                    isHoliday = true;
                }
            }

            if (today.DayOfWeek!= DayOfWeek.Saturday && today.DayOfWeek!=DayOfWeek.Sunday&&!isHoliday)
            {
                workingDays++;
            }

            today = today.AddDays(1);
            isHoliday = false;
        }

        return workingDays;
    }
}

