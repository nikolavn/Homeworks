//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter rows of matrix (rows>3):");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter cols of matrix (cols>3):");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        int maxSum = int.MinValue, tempSum = 0;
        int subMatrixSize = 3;

        GetIntMatrix(matrix);

        if (rows==subMatrixSize&&cols==subMatrixSize)
        {
            maxSum = 0;

            for (int subRow = 0; subRow < subMatrixSize; subRow++)
            {
                for (int subCol = 0; subCol < subMatrixSize; subCol++)
                {
                    maxSum += matrix[subRow, subCol];
                }
            }

            Console.WriteLine("Max Sum = {0}",maxSum);
            Console.WriteLine("Submatrix: ");
            PrintMatrix<int>(matrix);
        }
        else
        {
            for (int row = 0; row < rows - subMatrixSize; row++)
            {
                for (int col = 0; col < cols - subMatrixSize; col++)
                {
                    for (int subRow = 0; subRow < subMatrixSize; subRow++)
                    {
                        for (int subCol = 0; subCol < subMatrixSize; subCol++)
                        {
                            tempSum += matrix[subRow, subCol];
                        }
                    }

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        tempSum = 0;
                        int[,] subMatrix = new int[subMatrixSize, subMatrixSize];

                        for (int subRow = 0; subRow < subMatrixSize; subRow++)
                        {
                            for (int subCol = 0; subCol < subMatrixSize; subCol++)
                            {
                                subMatrix[subRow, subCol] = matrix[row + subRow, col + subCol];
                            }
                        }

                        Console.WriteLine("Max Sum = {0}", maxSum);
                        Console.WriteLine("Submatrix: ");
                        PrintMatrix<int>(subMatrix);
                    }
                }
            }
        }        
    }

    private static int[,] GetIntMatrix(int[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.WriteLine("Enter element [{0},{1}]: ", rows, cols);
                matrix[rows, cols] = int.Parse(Console.ReadLine());
            }
        }

        return matrix;
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

