using System;
using System.Collections.Generic;

class SolveTasks
{
    static void Main()
    {
        int choice = 0;
        bool isValidChoice = false;

        while (!isValidChoice)
        {
            Console.WriteLine("Choose what you want to do: ");
            Console.WriteLine("1.Reverse the digits of a number.");
            Console.WriteLine("2.Calculate average of sequence of numbers.");
            Console.WriteLine("3.Solve linear equation like: a*x + b = 0.");
            choice = int.Parse(Console.ReadLine());
            if ((choice == 1) || (choice == 2) || (choice == 3))
            {
                isValidChoice = true;
            }
        }

        switch (choice)
        {
            case 1:
                Console.Clear();
                decimal input = -1;
                while (!ValidateDecimal(input))
                {
                    Console.WriteLine("Enter positive number: ");
                    input = decimal.Parse(Console.ReadLine());
                }
                ReverseNumber(input);
                break;
            case 2:
                Console.Clear();
                List<int> numbers = new List<int>();
                string lineInput = String.Empty;
                string[] inputAsString = new string[lineInput.Length];

                while (!ValidateSequence(lineInput))
                {
                    Console.WriteLine("Enter integers separated by space: ");
                    lineInput = Console.ReadLine();
                    inputAsString = lineInput.Split();
                }

                foreach (var number in inputAsString)
                {
                    numbers.Add(int.Parse(number));
                }

                Console.WriteLine("Average of the numbers is: {0}",CalculateAverage(numbers));
                break;
            case 3:
                Console.Clear();
                double coefA = 0, coefB = 0;

                while (!ValidateEquation(coefA))
                {
                    Console.WriteLine("Enter coeficient A: ");
                    coefA = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter coeficient B: ");
                coefB = double.Parse(Console.ReadLine());

                if (coefB==0)
                {
                    Console.WriteLine("Equation {0}x = 0 is solved for x = 0",coefA);
                }
                else if (coefB>0)
                {
                    Console.WriteLine("Equation {0}x + {1} = 0 is solved for x = {2}",coefA,coefB,SolveEquation(coefA, coefB));
                }
                else
                {
                    Console.WriteLine("Equation {0}x - {1} = 0 is solved for x = {2}", coefA, Math.Abs(coefB), SolveEquation(coefA, coefB));
                }                
                break;
            default:
                Console.WriteLine("Invalid selection!"); break;
        }
    }

    private static bool ValidateDecimal(decimal number)
    {
        bool result = number > 0;
        return result;
    }

    private static bool ValidateSequence(string numbers)
    {
        bool result = numbers!=String.Empty;
        return result;
    }

    private static bool ValidateEquation(double coeficient)
    {
        bool result = (int)coeficient != 0;
        return result;
    }

    private static void ReverseNumber(decimal number)
    {
        Console.Write("\nReversed number --> ");
        while (number > 1)
        {
            int lastDigit = (int)number % 10;
            Console.Write(lastDigit);
            number = number / 10;
        }
        Console.WriteLine();
    }

    private static double CalculateAverage(List<int> numbers)
    {
        int sum = 0;

        for (int counter = 0; counter < numbers.Count; counter++)
        {
            sum += numbers[counter];
        }

        return sum / numbers.Count;
    }

    private static double SolveEquation(double aCoef, double bCoef)
    {
        double result = -bCoef / aCoef;
        return result;
    }
}

