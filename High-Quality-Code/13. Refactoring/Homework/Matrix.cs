using System;

namespace GameFifteen
{
    public class Matrix
    {
        public static int GetSize()
        {
            Console.WriteLine(MatrixConstants.EnterPostiveNumberPrompt);
            string input = Console.ReadLine();

            int matrixSize = 0;
            while (!int.TryParse(input, out matrixSize) || matrixSize < MatrixConstants.MinSize || matrixSize > MatrixConstants.MaxSize)
            {
                Console.WriteLine(MatrixConstants.WrongInputError);
                input = Console.ReadLine();
            }

            return matrixSize;
        }

        public static void Print(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.Write("{");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                    if (col < matrix.GetLength(1) - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write("},");
                Console.WriteLine();
            }
        }

        public static int[,] Create()
        {
            int size = GetSize();
            int[,] matrix = new int[size, size];
            return matrix;
        }
    }
}