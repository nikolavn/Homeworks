using System;
using System.Linq;
using System.Diagnostics;
using Assertions_Homework;

class AssertionsHomework
{
    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSortAlgorithm.Sort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        //SelectionSortAlgorithm.Sort(new int[0]); // Test sorting empty array
        //SelectionSortAlgorithm.Sort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearchAlgorithm.Search(arr, -1000));
        Console.WriteLine(BinarySearchAlgorithm.Search(arr, 0));
        Console.WriteLine(BinarySearchAlgorithm.Search(arr, 17));
        Console.WriteLine(BinarySearchAlgorithm.Search(arr, 10));
        Console.WriteLine(BinarySearchAlgorithm.Search(arr, 1000));
    }
}
