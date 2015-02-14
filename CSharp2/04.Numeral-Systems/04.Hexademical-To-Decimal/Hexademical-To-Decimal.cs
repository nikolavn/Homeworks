//Problem 4. Hexadecimal to decimal

//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexademicalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter hexademical to convert: ");
        string hexToConvert = Console.ReadLine();

        Console.WriteLine("\n{0} coverted to decimal is: {1}\n", hexToConvert, HexToDecimalConversion(hexToConvert));        
    }

    private static int HexToDecimalConversion(string hexInput)
    {
        int decimalResult = 0;

        //The hexademical number is taken as a string. For each char in it there is different expression
        //Result is added to the result.

        for (int i = 0, k = hexInput.Length - 1; i < hexInput.Length; i++, k--)
        {
            switch (hexInput[i])
            {
                case '1': decimalResult += 1 * (int)Math.Pow(16, k); break;
                case '2': decimalResult += 2 * (int)Math.Pow(16, k); break;
                case '3': decimalResult += 3 * (int)Math.Pow(16, k); break;
                case '4': decimalResult += 4 * (int)Math.Pow(16, k); break;
                case '5': decimalResult += 5 * (int)Math.Pow(16, k); break;
                case '6': decimalResult += 6 * (int)Math.Pow(16, k); break;
                case '7': decimalResult += 7 * (int)Math.Pow(16, k); break;
                case '8': decimalResult += 8 * (int)Math.Pow(16, k); break;
                case '9': decimalResult += 9 * (int)Math.Pow(16, k); break;
                case 'A': decimalResult += 10 * (int)Math.Pow(16, k); break;
                case 'B': decimalResult += 11 * (int)Math.Pow(16, k); break;
                case 'C': decimalResult += 12 * (int)Math.Pow(16, k); break;
                case 'D': decimalResult += 13 * (int)Math.Pow(16, k); break;
                case 'E': decimalResult += 14 * (int)Math.Pow(16, k); break;
                case 'F': decimalResult += 15 * (int)Math.Pow(16, k); break;

                default:
                    break;
            }
        }

        return decimalResult;
    }
}

