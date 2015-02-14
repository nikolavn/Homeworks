using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber>secondNumber)
        {
            double temp;
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("{0} {1}",firstNumber,secondNumber);
        }
        else
        {
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
		
    }
}

