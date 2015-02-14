//Problem 11. Adding polynomials

//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.
//Example:

//x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

using System;

class AddingPolinoms
{
    static void Main(string[] args)
    {
        int[] firstPolinom = { 5, 0, 2 };
        int[] secondPolinom = { 5, 3, 4 };

        Console.WriteLine("First polinom:");
        PrintPolinom(firstPolinom);   

        Console.WriteLine("Second polinom:");
        PrintPolinom(secondPolinom); 

        Console.WriteLine("Result sum: ");
        PrintPolinom(SumPolinoms(firstPolinom, secondPolinom));         
    }

    private static int[] SumPolinoms(int[] firstsCoeficients, int[] secondsCoefiecients)
    {
        int[] resultPolinom = new int[firstsCoeficients.Length];

        for (int coeficients = 0; coeficients < firstsCoeficients.Length; coeficients++)
        {
            resultPolinom[coeficients] = firstsCoeficients[coeficients] + secondsCoefiecients[coeficients];
        }

        return resultPolinom;
    }   

    private static void PrintPolinom(int[] coeficients)
    {

        if (coeficients[coeficients.Length-1]!=0)
        {
            Console.Write("{0}x^{1} ", coeficients[coeficients.Length - 1], coeficients.Length - 1); 
        }        
        
        for (int counter = coeficients.Length - 2; counter >= 0; counter--)
        {
            if (coeficients[counter] != 0)
            {
                if (counter > 1)
                {
                    if (coeficients[counter] > 0)
                    {
                        Console.Write("+ {0}x^{1} ", coeficients[counter], counter);
                    }
                    else
                    {
                        Console.Write("- {0}x^{1} ", Math.Abs(coeficients[counter]), counter);
                    }
                }
                else if (counter == 1)
                {
                    if (coeficients[1] >= 0)
                    {
                        Console.Write("+ {0}x ", coeficients[counter]);
                    }
                    else
                    {
                        Console.Write("- {0}x ", Math.Abs(coeficients[counter]));
                    }
                }
                else
                {
                    if (coeficients[0] >= 0)
                    {
                        Console.Write("+ {0}", coeficients[counter]);
                    }
                    else
                    {
                        Console.Write("- {0}", Math.Abs(coeficients[counter]));
                    }
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}

