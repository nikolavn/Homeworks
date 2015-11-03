//Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.

//Write a program to test whether the method works correctly.

namespace _04.LongestSubsequence
{
    using System;
    using System.Collections.Generic;

    using DataReader;

    class LongestSubsequence
    {
        static void Main()
        {
            List<int> numbersList = new List<int>();
            var dataReader = SampleDataReader.Create(Console.In);

            Console.WriteLine("Enter numbers: ");
            var currentNumber = dataReader.Read();

            while (!string.IsNullOrEmpty(currentNumber))
            {
                numbersList.Add(int.Parse(currentNumber));
                currentNumber = dataReader.Read();
            }

            var longestSequence = FindLongestSequence(numbersList);

            Console.WriteLine($"Sequence: {string.Join(",",numbersList)} --> { string.Join(",", longestSequence)}");
        }

        private static IList<int> FindLongestSequence(IList<int> list)
        {
            int maxSequenceLength = 1, currentElement = list[0], maxSequenceElement = 0, tempSequenceLength = 0;
            IList<int> longestSequence = new List<int>();

            for (int counter = 0; counter < list.Count; counter++)
            {
                if (list[counter] == currentElement)
                {
                    tempSequenceLength++;

                    if (counter == list.Count - 1) //ensures sequence will be caught if is in the end of array
                    {
                        if (tempSequenceLength > maxSequenceLength)
                        {
                            maxSequenceLength = tempSequenceLength;
                            maxSequenceElement = currentElement;
                        }
                    }
                }
                else
                {
                    if (tempSequenceLength > maxSequenceLength)
                    {
                        maxSequenceLength = tempSequenceLength;
                        maxSequenceElement = currentElement;
                    }
                    tempSequenceLength = 1;
                    currentElement = list[counter];
                }
            }

            for (int i = 0; i < maxSequenceLength; i++)
            {
                longestSequence.Add(maxSequenceElement);
            }

            return longestSequence;
        }
    }
}
