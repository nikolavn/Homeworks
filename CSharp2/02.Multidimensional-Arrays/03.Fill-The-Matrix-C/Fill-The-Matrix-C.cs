//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:

//7	 11	14	16
//4	 8	12	15
//2	 5	9	13
//1	 3	6	10

using System;

class FillTheMatrixC
{
    static void Main()
    {
        Console.WriteLine("Enter matrix size: ");
        int size = int.Parse(Console.ReadLine());

        int[,] matrix = new int[size, size];
        int counter = 1;

        for (int rows = 0; rows <= matrix.GetLength(0) - 1; rows++)
        {
            for (int cols = 0; cols <= rows; cols++)
            {
                matrix[size - rows + cols - 1, cols] = counter++;
            }
        }

        for (int rows = matrix.GetLength(0)-2; rows >=0; rows--)
        {
            for (int cols = rows; cols >= 0; cols--)
            {
                matrix[rows - cols, size - cols - 1] = counter++;
            }
        }


        PrintMatrix<int>(matrix);
    }

    private static void PrintMatrix<T>(T[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("{0,4}", matrix[rows, cols]);
            }

            Console.WriteLine();
        }
    }
}

