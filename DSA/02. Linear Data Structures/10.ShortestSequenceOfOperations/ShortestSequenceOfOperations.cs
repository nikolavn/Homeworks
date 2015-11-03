namespace _10.ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataReader;

    class ShortestSequenceOfOperations
    {
        static void Main()
        {
            var dataReader = SampleDataReader.Create(Console.In);

            Console.WriteLine("Enter start number: ");
            var start = int.Parse(dataReader.Read());

            Console.WriteLine("Enter end number: ");
            var end = int.Parse(dataReader.Read());

            Console.WriteLine($"Shortest sequence of operations: {string.Join(" --> ", FindShortestPathOfOperations(start, end))}");
        }

        private static IEnumerable<int> FindShortestPathOfOperations(int start, int end)
        {
            var result = new Queue<int>();

            while (start <= end)
            {
                result.Enqueue(end);

                if (end / 2 >= start)
                {
                    if (end % 2 == 0)
                    {
                        end = end / 2;
                    }
                    else
                    {
                        end--;
                    }
                }
                else
                {
                    if (end - 2 >= start)
                    {
                        end = end - 2;
                    }
                    else
                    {
                        end--;
                    }
                }

            }

            return result.Reverse();
        }
    }
}
