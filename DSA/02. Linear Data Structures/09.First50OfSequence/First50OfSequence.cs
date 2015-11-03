//We are given the following sequence:

//S1 = N;
//S2 = S1 + 1;
//S3 = 2* S1 + 1;
//S4 = S1 + 2;
//S5 = S2 + 1;
//S6 = 2* S2 + 1;
//S7 = S2 + 2;
//...
//Using the Queue<T> class write a program to print its first 50 members for given N.
//Example: N= 2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...

namespace _09.First50OfSequence
{
    using System;
    using System.Collections.Generic;

    using DataReader;

    class First50OfSequence
    {
        static void Main()
        {
            var dataReader = SampleDataReader.Create(Console.In);

            Console.WriteLine("Enter sequence start number: ");
            var sequenceStart = int.Parse(dataReader.Read());

            Console.WriteLine($"Sequence: {string.Join(",", First50Members(sequenceStart))}{Environment.NewLine}");
        }

        private static IEnumerable<int> First50Members(int start)
        {
            var sequence = new Queue<int>();
            var result = new List<int>();
            sequence.Enqueue(start);
            var curentMember = sequence.Peek();

            for (int i = 0; i < 50; i++)
            {
                curentMember = sequence.Dequeue();

                result.Add(curentMember);

                sequence.Enqueue(curentMember + 1);
                sequence.Enqueue(2 * curentMember + 1);
                sequence.Enqueue(curentMember + 2);
            }

            return result;
        }
    }
}
