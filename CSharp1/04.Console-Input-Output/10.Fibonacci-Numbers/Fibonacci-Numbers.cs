using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number of members: ");
        int numberOfMembers = int.Parse(Console.ReadLine());
        int firstMember = 0;
        int secondMember = 1;
        int nextMember;

        if (numberOfMembers == 1)
        {
            Console.WriteLine(firstMember);
        }
        else if (numberOfMembers == 2)
        {
            Console.WriteLine("{0}, {1}", firstMember, secondMember);
        }
        else
        {
            Console.Write("{0}, {1}, ", firstMember, secondMember);

            for (int counter = 2; counter < numberOfMembers; counter++)
            {
                nextMember = firstMember + secondMember;

                if (counter == numberOfMembers - 1)
                {
                    Console.Write(nextMember+"\n");
                    break;
                }

                Console.Write(nextMember + ", ");
                
                firstMember = secondMember;
                secondMember = nextMember;
            }
        }
    }
}

