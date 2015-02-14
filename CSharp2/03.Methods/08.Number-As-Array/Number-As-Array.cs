//Problem 8. Number as array

//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] 
//contains a digit; the last digit is kept in arr[0]).Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;

class NumberAsArray
{
    static void Main(string[] args)
    {
        int[] firstNumber = { 1, 2, 3, 4, 5, 8, 9 };
        int[] secondNumber = { 5, 4, 3, 8 };

        List<int> summed = SumArrays(firstNumber, secondNumber);

        foreach (var digit in summed)
        {
            Console.Write(digit);
        }
    }

    private static List<int> SumArrays(int[] firstNumber, int[] secondNumber)
    {
        int tens = 0, tempSum = 0;
        List<int> sum = new List<int>();

        if (firstNumber.Length > secondNumber.Length)
        {
            for (int digitsCounter = 0; digitsCounter < secondNumber.Length; digitsCounter++)
            {
                tempSum = (int)firstNumber[digitsCounter] + (int)secondNumber[digitsCounter] + tens;

                if (tempSum > 10)
                {
                    sum.Add(tempSum % 10);
                    tens = 1;
                    tempSum = 0;
                }
                else
                {
                    sum.Add(tempSum);
                    tens = 0;
                    tempSum = 0;
                }
            }

            for (int i = secondNumber.Length; i < firstNumber.Length; i++)
            {
                tempSum = firstNumber[i] + tens;

                if (tempSum > 10)
                {
                    sum.Add(tempSum % 10);
                    tens = 1;
                    tempSum = 0;
                }
                else
                {
                    sum.Add(tempSum);
                    tens = 0;
                    tempSum = 0;
                }
            }
        }
        else if (firstNumber.Length < secondNumber.Length)
        {
            for (int digitsCounter = 0; digitsCounter < firstNumber.Length; digitsCounter++)
            {
                tempSum = (int)firstNumber[digitsCounter] + (int)secondNumber[digitsCounter] + tens;

                if (tempSum > 10)
                {
                    sum.Add(tempSum % 10);
                    tens = 1;
                    tempSum = 0;
                }
                else
                {
                    sum.Add(tempSum);
                    tens = 0;
                    tempSum = 0;
                }
            }

            for (int i = firstNumber.Length; i < secondNumber.Length; i++)
            {
                tempSum = secondNumber[i] + tens;

                if (tempSum > 10)
                {
                    sum.Add(tempSum % 10);
                    tens = 1;
                    tempSum = 0;
                }
                else
                {
                    sum.Add(tempSum);
                    tens = 0;
                    tempSum = 0;
                }
            }
        }
        else
        {
            for (int digitsCounter = 0; digitsCounter < firstNumber.Length; digitsCounter++)
            {
                tempSum = (int)firstNumber[digitsCounter] + (int)secondNumber[digitsCounter] + tens;

                if (tempSum > 10)
                {
                    sum.Add(tempSum % 10);
                    tens = 1;
                    tempSum = 0;
                }
                else
                {
                    sum.Add(tempSum);
                    tens = 0;
                    tempSum = 0;
                }
            }
        }

        sum.Reverse();

        return sum;
    }
}

