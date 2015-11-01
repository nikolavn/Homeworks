namespace _02.ReverseNumbersSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataReader;

    public class ReverseNumbersSequence
    {
        static void Main()
        {
            Stack<int> numbersList = new Stack<int>();
            var dataReader = SampleDataReader.Create(Console.In);

            Console.WriteLine("Enter numbers: ");
            var currentNumber = dataReader.Read();

            while (!string.IsNullOrEmpty(currentNumber))
            {
                numbersList.Push(int.Parse(currentNumber));
                currentNumber = dataReader.Read();
            }

            Console.WriteLine($"Original: {string.Join(",", numbersList.Reverse())}");
            Console.WriteLine($"Reversed: {string.Join(",", ReverseOrder(numbersList))}");
        }

        private static ICollection<int> ReverseOrder(Stack<int> numbers)
        {
            IList<int> reversed = new List<int>();
            int elementsCount = numbers.Count;

            for (int i = 0; i < elementsCount; i++)
            {
                reversed.Add(numbers.Pop());
            }

            return reversed;
        }
    }
}
