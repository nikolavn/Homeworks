//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter binary to convert: ");
        string binaryToConvert = Console.ReadLine();

        Console.WriteLine("\n{0} coverted to decimal is: {1}\n", binaryToConvert, BinaryToDecimalConversion(binaryToConvert));
    }

    private static int BinaryToDecimalConversion(string binaryInput)
    {
        int decimalResult = 0;

        //Binary number is taken as a string after that each element of the string is parsed so we get an integer value 
        //the integer value is multiplied by 2 powered to the place of the element in the string and then added to the result

        for (int i = 0, k = binaryInput.Length - 1; i < binaryInput.Length; i++, k--)
        {
            decimalResult += int.Parse(binaryInput[i].ToString()) * (int)Math.Pow(2, k);
        }


        return decimalResult;
    }
}

