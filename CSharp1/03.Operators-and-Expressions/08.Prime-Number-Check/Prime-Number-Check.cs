using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int numberToCheck = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (numberToCheck<2)
        {
            isPrime = false;
        }
        else if (numberToCheck == 2)
        {

        }
        else
        {
            for (int i = 2; i < (int)Math.Sqrt(numberToCheck); i++)
            {
                if (numberToCheck % i == 0)
                {
                    isPrime = false;
                }
            }
        }
        Console.WriteLine("{0} is prime? {1}",numberToCheck,isPrime);
    }
}

