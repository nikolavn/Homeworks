using System;

class ThirdDigitis7
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Third digit is 7?");

        if (number/100 == 0)
        {
            Console.WriteLine("No.");
        }
        else
        {
            number = number / 100;
            if (number%10==7)
            {
                Console.WriteLine("Yes.");
            }
            else
            {
                Console.WriteLine("No.");
            }
        }
    }
}

