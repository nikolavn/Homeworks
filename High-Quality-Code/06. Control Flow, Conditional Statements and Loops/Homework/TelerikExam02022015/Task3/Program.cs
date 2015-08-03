using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        checked
        {
            ulong userInput = ulong.Parse(Console.ReadLine());
            //ulong userInput = 99999999999999999;
            int numberOfTransformations = 0, sum = 0;
            BigInteger result = 0, tempResult = 1;
            string inputAsString = userInput.ToString();
            int hasDigits = inputAsString.Length;

            while (inputAsString.Length > 1 && numberOfTransformations < 10)
            {
                while (hasDigits > 1)
                {
                    hasDigits--;
                    for (int counter = 0; counter < hasDigits; counter++)
                    {
                        if (counter % 2 == 0)
                        {
                            sum += int.Parse(inputAsString[counter].ToString());
                        }
                    }
                    tempResult *= (ulong)sum;
                    sum = 0;
                }

                inputAsString = tempResult.ToString();
                result = tempResult;
                tempResult = 1;
                hasDigits = inputAsString.Length;
                numberOfTransformations++;
            }

            if (numberOfTransformations < 10)
            {
                Console.WriteLine(numberOfTransformations);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}

