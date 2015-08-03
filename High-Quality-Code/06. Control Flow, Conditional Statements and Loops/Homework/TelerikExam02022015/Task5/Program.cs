using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
         int countOfNumbers = int.Parse(Console.ReadLine());
         List<int> concatenatedBits= new List<int>();
         List<int> reversedBits = new List<int>();
         int zerosSequence = 0, onesSequence = 0, bitsCounter = 0;
         int maxOnesSeq = int.MinValue, maxZerosSeq = int.MinValue;
         bool inZerosSequence = true, inOnesSequence = true;

        for (int counter = 0; counter < countOfNumbers; counter++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int position = 0; position < 30; position++)
            {
                int mask = 1 << position;
                int numberAndMask = (int)number & mask;
                int bit = (int)numberAndMask >> position;

                concatenatedBits.Add(bit);
            }
            concatenatedBits.Reverse();
            reversedBits.AddRange(concatenatedBits);
            concatenatedBits.Clear();
        }

        while (bitsCounter<reversedBits.Count)
        {
            if (reversedBits[bitsCounter]==1)
            {
                onesSequence++;
                inZerosSequence = false;
                inOnesSequence = true;
                if (zerosSequence>maxZerosSeq)
                {
                    maxZerosSeq = zerosSequence;
                }
                zerosSequence = 0;
            }
            else
            {
                zerosSequence++;
                inZerosSequence = true;
                inOnesSequence = false;
                if (onesSequence>maxOnesSeq)
                {
                    maxOnesSeq = onesSequence;
                }
                onesSequence = 0;
            }
            bitsCounter++;
        }

        if (inOnesSequence)
        {
            if (onesSequence > maxOnesSeq)
            {
                maxOnesSeq = onesSequence;
            }
            Console.WriteLine(maxZerosSeq);
            Console.WriteLine(maxOnesSeq);
        }
        else if(inZerosSequence)
        {
            if (zerosSequence > maxZerosSeq)
            {
                maxZerosSeq = zerosSequence;
            }
            Console.WriteLine(maxZerosSeq);
            Console.WriteLine(maxOnesSeq);
        }
        else
        {
            Console.WriteLine(maxZerosSeq);
            Console.WriteLine(maxOnesSeq);
        }
    }
}

