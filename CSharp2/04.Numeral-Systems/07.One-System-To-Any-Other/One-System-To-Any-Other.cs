using System;
using System.Collections.Generic;

class OneSystemToAnyOther
{
    static void Main()
    {
        bool isValidStartBase = false, isValidTargetBase = false;
        int inputBase = 0, convertToBase = 0;

        Console.WriteLine("Enter number to convert: ");
        string userInput = Console.ReadLine();

        while (!isValidStartBase)
        {
            Console.WriteLine("Enter base of system to convert from (>=2 and <=16): ");
            inputBase = int.Parse(Console.ReadLine());

            if (inputBase >= 2&&inputBase<=16)
            {
                isValidStartBase = true;
            }
        }

        while (!isValidTargetBase)
        {
            Console.WriteLine("Enter base of system to convert to (<=16 and >=2): ");
            convertToBase = int.Parse(Console.ReadLine());

            if (convertToBase <= 16&&convertToBase>=2)
            {
                isValidTargetBase = true;
            }
        }
        Console.WriteLine();
        Console.Write("{0} converted from {1}-base num system to {2}-base num system is: ", userInput, inputBase, convertToBase);
        BaseSToBaseDConversion(inputBase, convertToBase, userInput);
        Console.WriteLine();
        Console.WriteLine();
    }

    static void BaseSToBaseDConversion(int startBase, int targetBase, string numberInput)
    {

        BaseSToBaseDConversion(InputToBaseSConversion(numberInput, startBase), targetBase);
    }

    //First input is converted to decimal system  using the method for Binary to Decimal conversion
    // 2 is substituted with the value of the first base.

    private static int InputToBaseSConversion(string input, int baseS)
    {
        int decimalResult = 0;

        for (int i = 0, k = input.Length - 1; i < input.Length; i++, k--)
        {
            decimalResult += int.Parse(input[i].ToString()) * (int)Math.Pow(baseS, k);
        }

        return decimalResult;
    }

    //The decimal result from the previous method is converted to system with the second base
    //Special characters are included for systems with base>10.

    private static void BaseSToBaseDConversion(int inputDecimal, int baseD)
    {
        List<int> convertedNumber = new List<int>();
        char[] specials = { 'A', 'B', 'C', 'D', 'E', 'F' };
        int counter = 0;

        while (inputDecimal > 0)
        {
            convertedNumber.Add(inputDecimal % baseD);
            inputDecimal = inputDecimal / baseD;
            counter++;
        }

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

