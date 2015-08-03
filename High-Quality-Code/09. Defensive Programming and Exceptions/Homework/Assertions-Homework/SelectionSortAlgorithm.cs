using System;
using System.Diagnostics;
using System.Linq;


namespace Assertions_Homework
{
    internal class SelectionSortAlgorithm
    {
        public static void Sort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null && arr.Length > 0, "Input array is null or empty!");
            Debug.Assert(arr.Length > 1, "Array contains only 1 element");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }

            Debug.Assert(IsSorted(arr), "Array is not sorted, but is perceived as such!");
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null && arr.Length > 0, "Input array is null or empty!");

            Debug.Assert(startIndex >= 0 && startIndex <= arr.Length - 1, "Start index is outside boundaries of input array!");
            Debug.Assert(endIndex >= 0 && endIndex <= arr.Length - 1, "End index is outside boundaries of input array!");
            Debug.Assert(startIndex <= endIndex, "Start index is greater than end index");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x != null, "X value is null");
            Debug.Assert(y != null, "Y value is null");

            T oldX = x;
            x = y;
            y = oldX;
        }

        private static bool IsSorted<T>(T[] array)
            where T : IComparable<T>
        {
            for (int index = 0; index < array.Length - 2; index++)
            {
                if (array[index].CompareTo(array[index + 1]) > 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
