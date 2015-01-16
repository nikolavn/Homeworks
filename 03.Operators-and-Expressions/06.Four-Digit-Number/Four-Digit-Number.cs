using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int firstDigit, secondDigit, thirdDigit, fourthDigit;

        firstDigit = number/1000;
        number=number%1000;
        secondDigit = number/100;
        number = number%100;
        thirdDigit = number/10;
        fourthDigit = number%10;

        Console.WriteLine("Sum of digits: {0}",(firstDigit+secondDigit+thirdDigit+fourthDigit));
        Console.WriteLine("Reversed number: {0}{1}{2}{3}",fourthDigit,thirdDigit,secondDigit,firstDigit);
        Console.WriteLine("Last digit first: {0}{1}{2}{3}",fourthDigit,firstDigit,secondDigit,thirdDigit);
        Console.WriteLine("Second and third digits swapped: {0}{1}{2}{3}",firstDigit,thirdDigit,secondDigit,fourthDigit);
    }
}

