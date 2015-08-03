using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public static class GameEnvironment
    {

        private const int FIELD_ROWS = 5;
        private const int FIELD_COLS = 10;
        private const int MAX_COUNT_OF_RANDOM_NUMBERS = 15;
        private const int MAX_VALUE_OF_RANDOM_NUMBERS = 50;

        public static void PrintLeaderBoard(List<Player> players)
        {
            Console.WriteLine("\nTo4KI:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }        

        public static void PrintPlayField(char[,] board)
        {
            int numberOfRows = board.GetLength(0);
            int numberOfColumns = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < numberOfRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < numberOfColumns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        public static char[,] CreatePlayField()
        {
            int boardRows = FIELD_ROWS;
            int boardColumns = FIELD_COLS;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        public static char[,] PlantMines()
        {
            int rows = FIELD_ROWS;
            int columns = FIELD_COLS;
            char[,] playField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playField[i, j] = '-';
                }
            }

            List<int> randomNumbers = new List<int>();

            while (randomNumbers.Count < MAX_COUNT_OF_RANDOM_NUMBERS)
            {
                Random random = new Random();
                int randomNumber = random.Next(MAX_VALUE_OF_RANDOM_NUMBERS);
                if (!randomNumbers.Contains(randomNumber))
                {
                    randomNumbers.Add(randomNumber);
                }
            }

            foreach (int number in randomNumbers)
            {
                int col = (number / columns);
                int row = (number % columns);
                if (row == 0 && number != 0)
                {
                    col--;
                    row = columns;
                }
                else
                {
                    row++;
                }
                playField[col, row - 1] = '*';
            }

            return playField;
        }

        //Method not used for now.
        //
        //public static void Calculations(char[,] playField)
        //{
        //    int row = playField.GetLength(0);
        //    int col = playField.GetLength(1);

        //    for (int i = 0; i < row; i++)
        //    {
        //        for (int j = 0; j < col; j++)
        //        {
        //            if (playField[i, j] != '*')
        //            {
        //                char amountOfMines = CalculateNumberOfMines(playField, i, j);
        //                playField[i, j] = amountOfMines;
        //            }
        //        }
        //    }
        //}

        public static char CalculateNumberOfMines(char[,] playField, int row, int col)
        {
            int numberOfMines = 0;
            int rows = playField.GetLength(0);
            int cols = playField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (playField[row - 1, col] == '*')
                {
                    numberOfMines++;
                }
            }
            if (row + 1 < rows)
            {
                if (playField[row + 1, col] == '*')
                {
                    numberOfMines++;
                }
            }
            if (col - 1 >= 0)
            {
                if (playField[row, col - 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if (col + 1 < cols)
            {
                if (playField[row, col + 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (playField[row - 1, col - 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (playField[row - 1, col + 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (playField[row + 1, col - 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (playField[row + 1, col + 1] == '*')
                {
                    numberOfMines++;
                }
            }
            return char.Parse(numberOfMines.ToString());
        }
    }
}
