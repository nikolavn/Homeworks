using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Greater number is: {0}",firstNumber > secondNumber ? firstNumber : secondNumber);
    }
}

