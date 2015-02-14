//Problem 3. Decimal to hexadecimal

//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;

class DecimalToHexademical
{
    static void Main()
    {
        Console.WriteLine("Enter number to convert to binary: ");
        int decimalToConvert = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("{0} converted to hexademical is: ", decimalToConvert);
        DecimalToHexademicalConversion(decimalToConvert);
        Console.WriteLine();
        Console.WriteLine();
    }

    private static void DecimalToHexademicalConversion(int inputDecimal)
    {
        List<int> convertedNumber = new List<int>();
        char[] specials = { 'A', 'B', 'C', 'D', 'E', 'F' };
        int counter = 0;

        //Array is created and each element of the array is equal to the reminder after the number
        //is devided by 16. Then the number appropriates the value of the number divided by 16.

        while (inputDecimal > 0)
        {
            convertedNumber.Add(inputDecimal % 16);
            inputDecimal = inputDecimal / 16;
            counter++;
        }

        //While printing if the value is larger than 10 the value is taken from the array with special characters
        //of the hexademical numeral system.

        for (int i = convertedNumber.Count - 1; i >= 0; i--)
        {
            if (convertedNumber[i] < 10)
            {
                Console.Write(convertedNumber[i]);
            }
            if (convertedNumber[i] >= 10)
            {
                Console.Write(specials[convertedNumber[i] - 10]);
            }
        }
    }
}

