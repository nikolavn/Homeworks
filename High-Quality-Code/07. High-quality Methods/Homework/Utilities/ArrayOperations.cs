using System;

namespace Utilities
{
    /// <summary>
    /// Class that provides additional functionality for arrays.
    /// </summary>
    public class ArrayOperations
    {
        /// <summary>
        /// Method to find the element with maximum value in array of integers
        /// </summary>
        /// <param name="elements">Array of integer values.</param>
        /// <returns>The element with maximum value.</returns>
        public static int FindMaxValuedElement(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("There are no elements to search in.");
            }

            int maxElement = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }
            return maxElement;
        }
    }
}
