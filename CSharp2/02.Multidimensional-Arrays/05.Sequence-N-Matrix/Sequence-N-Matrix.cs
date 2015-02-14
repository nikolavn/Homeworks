//Problem 3. Sequence n matrix

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
//Example:

//matrix	                result		            matrix	      result
//ha	fifi	ho	hi                              s	qq	s
//fo	ha	    hi	xx    ha, ha, ha                pp	pp	s     s, s, s
//xxx	ho	    ha	xx                              pp	qq	s		

using System;

class SequenceNMatrix
{
    private static string[,] matrix;
    private static int[] directionsCols = { 1, 0, 1, 0 };
    private static int[] directionsRows = { 0, 1, 1, -1 };
    private static int maxLineLength = 1;
    private static string maxLineElement;

    static void Main()
    {     

        matrix = new string[,] {          
                    {"ha","fifi","ho","hi"},
                    {"fo","ha","hi","xx"},
                    {"xx","ho","ha","xx"}
                          };
        
        


        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                CheckElements(row, col);
            }
        }

        Console.WriteLine(maxLineLength);
        Console.WriteLine(maxLineElement);
    }

    private static void CheckElements(int currentRow, int currentCol)
    {
        for (int counter = 0; counter < directionsCols.Length; counter++)
        {
            string currentElement = matrix[currentRow, currentCol];
            int currentLength = 1;
            int currentElementRow = currentRow;
            int currentElementCol = currentCol;

            while (true)
            {
                currentElementRow += directionsRows[counter];
                currentElementCol += directionsCols[counter];                

                if (!IsInMatrix(currentElementRow, currentElementCol))
                {
                    break;
                }

                if (matrix[currentElementRow, currentElementCol] == currentElement)
                {
                    currentLength++;
                }
                else
                {
                    break;
                }
            }

            if (currentLength > maxLineLength)
            {
                maxLineLength = currentLength;
                maxLineElement = currentElement;
            }
            else
            {
                currentLength = 1;
            }
        }
    }

    private static bool IsInMatrix(int row, int col)
    {
        if (row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

