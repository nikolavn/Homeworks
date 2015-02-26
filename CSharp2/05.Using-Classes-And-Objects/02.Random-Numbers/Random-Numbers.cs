using System;

class RandomNumbers
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int start = 100, end = 200,count = 10;

        Console.WriteLine("{2} random numbers in interval [{0}, {1}]:",start,end,count);

        for (int i = 0; i < count; i++)
        {
            int randomNumber = randomGenerator.Next(start,end+1);
            Console.Write(randomNumber+" ");
        }

        Console.WriteLine();
    }
}

