using System;

class InvalidRangeExceptionTests
{
    static void Main()
    {
        int intRangeStart = 1, intRangeEnd = 100;
        DateTime dtRangeStart = new DateTime(1980,1,1),dtRangeEnd = new DateTime(2013,12,31);

        try
        {
            int intTestValue = 12746;

            if (intTestValue<intRangeStart||intTestValue>intRangeEnd)
            {
                throw new InvalidRangeException<int>(intRangeStart, intRangeEnd);
            }
        }
        catch (InvalidRangeException<int> ire)
        {
            Console.WriteLine("{0}[{1} - {2}]",ire.Message,ire.RangeStart,ire.RangeEnd);
        }

        try
        {
            DateTime dtTestValue = DateTime.Today;

            if (dtTestValue < dtRangeStart || dtTestValue > dtRangeEnd)
            {
                throw new InvalidRangeException<DateTime>(dtRangeStart, dtRangeEnd);
            }
        }
        catch (InvalidRangeException<DateTime> ire)
        {
            Console.WriteLine("{0}[{1} - {2}]", ire.Message, ire.RangeStart.ToString("yyyy.MM.dd"), ire.RangeEnd.ToString("yyyy.MM.dd"));
        }
    }
}

