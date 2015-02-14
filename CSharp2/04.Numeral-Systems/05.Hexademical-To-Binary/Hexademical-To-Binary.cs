//Problem 5. Hexadecimal to binary

//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexademicalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter hexademical to convert: ");
        string hexToConvert = Console.ReadLine();
        
        Console.Write("\n{0} coverted to binary(directly) is: {1} \n", hexToConvert, HexToBinDirectConversion(hexToConvert).PadLeft(32, '0'));
        
    }

    private static string HexToBinDirectConversion(string hexInput)
    {
        string binaryResult = null;

        //The hexademical number is taken as a string. For each char in it there is string that represents it in binary system.
        //Each string is concatenated to the result string.

        for (int i = 0; i < hexInput.Length; i++)
        {
            switch (hexInput[i])
            {
                case '0': binaryResult += String.Concat("0000"); break;
                case '1': binaryResult += String.Concat("0001"); break;
                case '2': binaryResult += String.Concat("0010"); break;
                case '3': binaryResult += String.Concat("0011"); break;
                case '4': binaryResult += String.Concat("0100"); break;
                case '5': binaryResult += String.Concat("0101"); break;
                case '6': binaryResult += String.Concat("0110"); break;
                case '7': binaryResult += String.Concat("0111"); break;
                case '8': binaryResult += String.Concat("1000"); break;
                case '9': binaryResult += String.Concat("1001"); break;
                case 'A': binaryResult += String.Concat("1010"); break;
                case 'B': binaryResult += String.Concat("1011"); break;
                case 'C': binaryResult += String.Concat("1100"); break;
                case 'D': binaryResult += String.Concat("1101"); break;
                case 'E': binaryResult += String.Concat("1110"); break;
                case 'F': binaryResult += String.Concat("1111"); break;

                default:
                    break;
            }
        }

        return binaryResult;
    }
}

