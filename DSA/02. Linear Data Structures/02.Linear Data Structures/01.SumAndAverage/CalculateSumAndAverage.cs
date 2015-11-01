namespace _01.SumAndAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DataReader;

    public class CalculateSumAndAverage
    {
        static void Main()
        {
            IList<int> numbersList = new List<int>();
            var dataReader = SampleDataReader.Create(Console.In);

            Console.WriteLine("Enter numbers: ");
            var currentNumber = dataReader.Read();

            while (!string.IsNullOrEmpty(currentNumber))
            {
                numbersList.Add(int.Parse(currentNumber));
                currentNumber = dataReader.Read();
            }            

            Console.WriteLine($"The sum of {string.Join(",",numbersList)} is: {CalculateSum(numbersList)}");
            Console.WriteLine($"The average of {string.Join(",", numbersList)} is: {CalculateAverage(numbersList)}");
        }

        private static int CalculateSum(IList<int> numbers)
        {
            return numbers.Sum();
        }

        private static double CalculateAverage(IList<int> numbers)
        {
            return numbers.Average();
        }
    }
}
