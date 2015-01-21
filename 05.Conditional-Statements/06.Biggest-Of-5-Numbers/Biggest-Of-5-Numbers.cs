using System;
using System.Threading;
using System.Globalization;


class BiggestOf5Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());

        double biggest = firstNumber;        

        if (biggest < secondNumber)
        {
            biggest = secondNumber;
        }
        if (biggest < thirdNumber)
        {
            biggest = thirdNumber;
        }
        if (biggest < fourthNumber)
        {
            biggest = fourthNumber;
        }
        if (biggest < fifthNumber)
        {
            biggest = fifthNumber;
        }

        Console.WriteLine(biggest);

    }
}

