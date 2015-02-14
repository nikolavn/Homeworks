//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:

//1	 8	9	16
//2	 7	10	15
//3	 6	11	14
//4	 5	12	13

using System;

class FillTheMatrixB
{
    static void Main()
    {
        Console.WriteLine("Enter matrix size: ");
        int size = int.Parse(Console.ReadLine());

        int[,] matrix = new int[size, size];
        int counter = 1;

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {

            if (rows % 2 == 0)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = counter;
                    counter++;
                }
            }
            else
            {
                for (int cols = matrix.GetLength(1)-1; cols >= 0; cols--)
                {
                    matrix[rows, cols] = counter;
                    counter++;
                }
            }
        }

        PrintMatrix<int>(matrix);
    }

    private static void PrintMatrix<T>(T[,] matrix)
    {
        for (int cols = 0; cols < matrix.GetLength(0); cols++)
        {
            for (int rows = 0; rows < matrix.GetLength(1); rows++)
            {
                Console.Write("{0,4}", matrix[rows, cols]);
            }

            Console.WriteLine();
        }
    }
}

