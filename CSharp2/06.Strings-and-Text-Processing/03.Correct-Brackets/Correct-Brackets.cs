//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;

class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Enter expression to evaluate: ");
        string expression = Console.ReadLine();

        Console.WriteLine("Brackets are correctly put? {0}",CheckBrackets(expression));
    }

    private static bool CheckBrackets(string expression)
    {
        int openingBrackets = 0, closingBrackets = 0;

        for (int counter = 0; counter < expression.Length; counter++)
        {
            if (expression[counter]=='(')
            {
                openingBrackets++;
            }

            if (expression[counter]==')')
            {
                closingBrackets++;
            }
        }

        return openingBrackets == closingBrackets;
    }
}

