//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter number to convert to binary: ");
        int decimalToConvert = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("{0} converted to binary is: ", decimalToConvert);  
        DecimalToBinaryConversion(decimalToConvert);
        Console.WriteLine();
    }

    private static void DecimalToBinaryConversion(int inputDecimal)
    {
        int[] convertedNumber = new int[32];
        int counter = 0;

        while (inputDecimal > 0)
        {
            //Array is created and each element of the array is equal to the reminder after the number
            //is devided by 2. Then the number appropriates the value of the number divided by 2.

            convertedNumber[counter] = inputDecimal % 2;
            inputDecimal = inputDecimal / 2;
            counter++;
        }

        //Array is printer backwords        

        for (int i = convertedNumber.Length - 1; i >= 0; i--)
        {
            Console.Write(convertedNumber[i]);
        }
    }
}

