using System;

class PrimeNumbers
{
    static void Main()
    {
        //Console.WriteLine("Enter end of range: ");
        //int endOfRange = int.Parse(Console.ReadLine());
        int endOfRange = 300;
        bool[] primes = new bool[endOfRange];

        for (int i = 2; i < primes.Length; i++)
        {
            primes[i] = true;
        }

        for (int startPosition = 2; startPosition < Math.Sqrt(endOfRange); startPosition++)
        {
            if (primes[startPosition])
            {
                for (int nextPosition = (startPosition * startPosition); nextPosition < endOfRange; nextPosition += startPosition)
                {
                    primes[nextPosition] = false;
                }
            }
        }

        Console.WriteLine("Prime numbers from [1-{0}]: ",endOfRange);       

        for (int number = 0; number < primes.Length; number++)
        {         
            if (primes[number])
            {
                Console.Write(number + " ");
            }
        }

        Console.WriteLine();
    }
}

