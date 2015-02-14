using System;

class NumberAsWords
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");

        int number = int.Parse(Console.ReadLine());

        string[] hundreds = { "one hundred", "two hundred", "three hundred", "four hundred", "five hundred", 
                                "six hundred", "seven hundred", "eight hundred", "nine hundred" };
        string[] tens = { "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] special = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", 
                               "eighteen", "nineteen" };

        int firstDigit = number / 100;
        int secondDigit = (number % 100) / 10;
        int thirdDigit = number % 10;

        if (number >= 0 && number < 10)
        {
            Console.WriteLine("The number you entered is: {0}", ones[thirdDigit]);
        }
        else if (number >= 10 && number < 20)
        {
            Console.WriteLine("The number you entered is: {0}", special[thirdDigit - 1]);
        }
        else if (number >= 20 && number < 100 && thirdDigit != 0)
        {
            Console.WriteLine("The number you entered is: {0} {1}", tens[secondDigit - 1], ones[thirdDigit]);
        }
        else if (number >= 20 && number < 100 && thirdDigit == 0)
        {
            Console.WriteLine("The number you entered is: {0}", tens[secondDigit - 1]);
        }
        else if (number >= 100)
        {
            switch (secondDigit)
            {
                case 0:
                    switch (thirdDigit)
                    {
                        case 0:
                            Console.WriteLine("The number you entered is: {0}", hundreds[firstDigit - 1]); break;
                        default:
                            Console.WriteLine("The number you entered is: {0} and {1}", hundreds[firstDigit - 1],
                                ones[thirdDigit]);
                            break;
                    } break;

                case 1:
                    Console.WriteLine("The number you entered is: {0} and {1}",
                        hundreds[firstDigit - 1], special[thirdDigit - 1]); break;
                default:
                    Console.WriteLine("The number you entered is: {0} and {1} {2}",
                        hundreds[firstDigit - 1], tens[secondDigit - 1], ones[thirdDigit]); break;
            }
        }
    }
}

