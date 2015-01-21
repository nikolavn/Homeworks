using System;
using System.Collections.Generic;

class SubsetZero
{
    static void Main()
    {
        int[] numbers = { 1, 3, -4, -2, -1 };//All combinations of the numbers in this array coule be represented as the
        int combinations = 32;               //binary values of numbers 1 -> 2^length-of-array in this case 2^5 or 32   
        int targetSum = 0;
        List<int> zeroSubset = new List<int>();

        for (int i = 1; i < combinations; i++)
        {
            int tempSum = 0;
            zeroSubset.Clear(); //list with members is cleared at each itteration
            for (int j = 0; j < numbers.Length; j++)
            {
                int mask = 1 << j;        //for each bit in our combinations we check if bit is 1 or 0. Each bit is a 
                int iAndMask = i & mask;  //number from the array. For example combination 17 takes numbers 1 and -1, 
                int bit = iAndMask >> j;  //because 17 in binary is 10001
                //Console.Write(bit);

                if (bit == 1)
                {
                    tempSum += numbers[j];      //if bit is 1 we take the number and add it to the sum and the list of 
                    zeroSubset.Add(numbers[j]); //numbers that form the sum
                }
            }

            if (tempSum == targetSum) //if sum is zero we print the members that form that sum 
            {
                for (int counter = 0; counter < zeroSubset.Count; counter++)
                {
                    Console.Write(zeroSubset[counter] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

