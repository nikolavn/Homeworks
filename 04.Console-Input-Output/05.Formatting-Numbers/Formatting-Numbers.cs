using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}", 
            firstNumber, Convert.ToString(firstNumber, 2).PadLeft(10, '0'), secondNumber, thirdNumber);
    }
}

