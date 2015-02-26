using System;

class LeapYear
{
    static void Main()
    {        
        int input = 0;
        bool isValidInput = false;

        while (!isValidInput)
        {
            Console.WriteLine("Enter year to check: ");
            input = int.Parse(Console.ReadLine());

            if (input < 9999 && input >= 1)
            {
                isValidInput = true;
            }
        }

        Console.WriteLine("{0} is leap year?: {1}",input,DateTime.IsLeapYear(input));
    }
}

