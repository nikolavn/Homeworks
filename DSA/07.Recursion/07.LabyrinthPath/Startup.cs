namespace _07.LabyrinthPath
{
    using System;

    class Startup
    {
        static char[,] lab =
    {
        {' ', ' ', ' ', '*', ' ', ' ', ' '},
        {'*', '*', ' ', '*', ' ', '*', ' '},
        {' ', ' ', ' ', ' ', ' ', ' ', ' '},
        {' ', '*', '*', '*', '*', '*', ' '},
        {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
    };

        static void Main()
        {
            FindPath(0, 0);
        }

        private static bool IsInLabyrinth(int row, int col, char[,] labyrinth)
        {
            bool rowIsInRange = 0 <= row && row < labyrinth.GetLength(0);
            bool colIsInRange = 0 <= col && col < labyrinth.GetLength(1);

            return rowIsInRange && colIsInRange;
        }

        private static bool IsCellFree(int row, int col, char freeCellChar, char[,] labyrinth)
        {
            return labyrinth[row, col] == freeCellChar;
        }

        private static void FindPath(int row, int col)
        {
            if (!IsInLabyrinth(row, col, lab))
            {
                return;

            }

            if (lab[row, col] == 'e')
            {
                PrintLabyrinth(lab);
            }

            if (!IsCellFree(row, col, ' ', lab))
            {
                return;
            }

            lab[row, col] = '+';

            FindPath(row + 1, col);
            FindPath(row - 1, col);
            FindPath(row, col + 1);
            FindPath(row, col - 1);

            lab[row, col] = ' ';
        }

        private static void PrintLabyrinth(char[,] labyrinth)
        {
            for (int row = 0; row < labyrinth.GetLength(0); row++)
            {
                for (int col = 0; col < labyrinth.GetLength(1); col++)
                {
                    Console.Write("{0,2}|",labyrinth[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
