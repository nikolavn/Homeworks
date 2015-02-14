using System;
using System.Collections.Generic;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Enter interval start: ");
        int intervalStart = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter interval end: ");
        int intervalEnd = int.Parse(Console.ReadLine());

        int count = 0;
        List<int> members = new List<int>();

        for (int i = intervalStart; i <= intervalEnd; i++)
        {
            if (i % 5 == 0)
            {
                count++;
                members.Add(i);
            }
        }

        if (count > 0)
        {
            Console.Write("\nThere are {0} numbers, that divide by 5 between {1} and {2}, they are: "
                ,count, intervalStart, intervalEnd);

            for (int j = 0; j < members.Count; j++)
            {
                if (j == members.Count - 1)
                {
                    Console.Write(members[j]);
                }
                else
                {
                    Console.Write(members[j] + ",");
                }
            }
        }
        else
        {
            Console.WriteLine("\nThere are no numbers, that divide by 5 between {0} and {1}."
                ,intervalStart, intervalEnd);
        }
    }
}
