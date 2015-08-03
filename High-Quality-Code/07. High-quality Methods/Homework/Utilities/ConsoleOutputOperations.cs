using System;

namespace Utilities
{
    /// <summary>
    /// Class that provides methods for printing information on the console
    /// </summary>
    public class ConsoleOutputOperations
    {
        /// <summary>
        /// Method that prints digit as word on the console
        /// </summary>
        /// <param name="number">Integer input</param>
        /// <returns>Word that corresponds to the entered digit</returns>
        public static string DigitAsWord(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            return "Invalid digit!";
        }

        /// <summary>
        /// Method to print number with given digits after the decimal separator
        /// </summary>
        /// <param name="number">Number integer/float</param>
        /// <param name="decimals">Number of digits after the decimal separator as integer value</param>
        public static void PrintWithDigitsAfterDecimal(object number, int decimals)
        {
            Console.WriteLine("{0:f" + decimals + "}", number);
        }

        /// <summary>
        /// Method that prints number as percent with given digits after the decimal separator
        /// </summary>
        /// <param name="number">Number integer/float</param>
        /// <param name="decimals">Number of digits after the decimal separator as integer value</param>
        public static void PrintAsPercent(object number,int decimals)
        {
            Console.WriteLine("{0:p" + decimals + "}", number);
        }

        /// <summary>
        /// Method that prints a number right aligned with given padding
        /// </summary>
        /// <param name="number">Number integer/float</param>
        /// <param name="paddingSpaces">Padding spaces</param>
        public static void PrintRightAligned(object number, int paddingSpaces)
        {
            Console.WriteLine("{0," + paddingSpaces + "}", number);
        }
    }
}
