//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:

//1	 5	9	13
//2	 6	10	14
//3	 7	11	15
//4	 8	12	16

using System;

class FillTheMatrixA
{
    static void Main()
    {
        Console.WriteLine("Enter matrix size: ");
        int size = int.Parse(Console.ReadLine());

        int[,] matrix = new int[size, size];
        int counter = 1;

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                matrix[rows, cols] = counter;
                counter++;
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
                Console.Write("{0,4}",matrix[rows,cols]);
            }

            Console.WriteLine();
        }
    }
}

