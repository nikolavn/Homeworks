//Problem 8. Binary short

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;

class BinaryShort
{
    static void Main()
    {
        bool isValidInput = false;
        short userInput = 0;

        while (!isValidInput)
        {
            Console.WriteLine("Enter number of type short to convert: ");
            userInput = short.Parse(Console.ReadLine());

            if (userInput < 32767 && userInput > -32768)
            {
                isValidInput = true;
            }
        }

        if (userInput > 0)
        {            
            Console.Write("\n{0} in binary is: {1}\n\n", userInput, ShortToBinaryConversion(userInput).PadLeft(16, '0'));           
        }
        else
        {
            Console.Write("\n{0} in binary is: {1}\n\n", userInput, ShortToBinaryConversion(userInput).PadLeft(16, '1'));
        }
    }

    private static string ShortToBinaryConversion(short inputValue)
    {
        List<short> convertedNumber = new List<short>();
        string result = "";

        //The short value is converted to binary the usual way. The remiders of the division are added to a list which is then reversed
        //Result is printed

        if (inputValue >= 0)
        {
            while (Math.Abs(inputValue) > 0)
            {
                convertedNumber.Add((short)(Math.Abs(inputValue) % 2));
                inputValue = (short)(Math.Abs(inputValue) / 2);

            }

            convertedNumber.Reverse();

            for (int i = 0; i < convertedNumber.Count; i++)
            {
                result += convertedNumber[i];
            }
        }

        //For negative numbers, number is converted the usual way to binary and then when printing 0s are replaced by 1s and vice versa

        if (inputValue < 0)
        {
            inputValue = (short)(Math.Abs(inputValue) - 1);

            while (Math.Abs(inputValue) > 0)
            {
                convertedNumber.Add((short)(Math.Abs(inputValue) % 2));
                inputValue = (short)(Math.Abs(inputValue) / 2);
            }

            convertedNumber.Reverse();

            for (int i = 0; i < convertedNumber.Count; i++)
            {
                if (convertedNumber[i] == 0)
                {
                    result += "1";
                }

                if (convertedNumber[i] == 1)
                {
                    result += "0";
                }
            }
        }

        return result;
    }
}

