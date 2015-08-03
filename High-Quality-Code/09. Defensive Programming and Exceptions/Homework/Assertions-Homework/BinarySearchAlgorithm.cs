using System;
using System.Diagnostics;
using System.Linq;

namespace Assertions_Homework
{
    internal class BinarySearchAlgorithm
    {
        public static int Search<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr != null && arr.Length > 0, "Input array is null or empty.");

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null && arr.Length > 0, "Input array is null or empty!");

            Debug.Assert(value != null, "Searched value is null");

            Debug.Assert(startIndex >= 0 && startIndex <= arr.Length - 1, "Start index is outside boundaries of input array!");
            Debug.Assert(endIndex >= 0 && endIndex <= arr.Length - 1, "End index is outside boundaries of input array!");
            Debug.Assert(startIndex <= endIndex, "Start index is greater than end index");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    Debug.Assert(arr.Any(element => element.Equals(value)), "Searched value is not in array but is found");

                    return midIndex;
                }
                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            Debug.Assert(!arr.Any(element => element.Equals(value)), "Searched value is not in array");

            return -1;
        }
    }
}
