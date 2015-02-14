//Problem 6. binary to hexadecimal

//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexademical
{
    static void Main()
    {
        Console.WriteLine("Enter binary to convert: ");
        string binaryToConvert = Console.ReadLine();

        Console.WriteLine("\n{0} converted to hexademical(directly) is: {1}\n", binaryToConvert, BinToHexDirectConversion(binaryToConvert));
    }

    private static string BinToHexDirectConversion(string binInput)
    {
        string[] binDigitsSequence = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
        string[] hexDigits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        string binDigitsSequenceCheck = null;
        string hexResult = null;

        //Binary number is taken as a string. Then is seperated into sequences of 4 elements. 
        //They are then compared to the sequence representing the hexademical value and it is added to the result string.

        for (int i = 0; i < binInput.Length - 3; i += 4)
        {

            for (int counter = i; counter < i + 4; counter++)
            {
                binDigitsSequenceCheck += String.Concat(binInput[counter].ToString());

            }

            for (int j = 0; j < binDigitsSequence.Length; j++)
            {

                if (String.Compare(binDigitsSequenceCheck, binDigitsSequence[j]) == 0)
                {
                    hexResult += String.Concat(hexDigits[j]);
                    binDigitsSequenceCheck = null;
                }
            }
        }

        return hexResult;
    }
}

