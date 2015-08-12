using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameFifteen
{
    class MatrixTraversal
    {
        private static void FindNextEmptyCell(int[,] matrix, out int currentRow, out int currentCol)
        {
            currentRow = 0;
            currentCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        currentRow = row;
                        currentCol = col;
                        return;
                    }
                }
        }
    }
}
