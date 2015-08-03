using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Minesweeper;

namespace MineSweeper
{
    public class Mines
    {
        static void Main(string[] args)
        {
            const int MAX_NUMBER_OF_CELLS = 35;
            const int MAX_NUMBER_OF_BEST_PLAYERS = 5;

            List<Player> bestPlayers = new List<Player>(MAX_NUMBER_OF_BEST_PLAYERS+1);
            string inputCommand = string.Empty;
            char[,] playField = GameEnvironment.CreatePlayField();
            char[,] mines = GameEnvironment.PlantMines();
            int cellsCounter = 0;
            int playFieldRow = 0;
            int playFieldColumn = 0;
            bool isMineActivated = false;
            bool hasNewGameStarted = true;
            bool isGameWon = false;

            do
            {
                if (hasNewGameStarted)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    GameEnvironment.PrintPlayField(playField);
                    hasNewGameStarted = false;
                }

                Console.Write("Daj red i kolona : ");

                inputCommand = Console.ReadLine().Trim();

                if (inputCommand.Length >= 3)
                {
                    if (int.TryParse(inputCommand[0].ToString(), out playFieldRow) &&
                        int.TryParse(inputCommand[2].ToString(), out playFieldColumn) &&
                        playFieldRow <= playField.GetLength(0) && playFieldColumn <= playField.GetLength(1))
                    {
                        inputCommand = "turn";
                    }
                }

                switch (inputCommand)
                {
                    case "top":
                        GameEnvironment.PrintLeaderBoard(bestPlayers);
                        break;
                    case "restart":
                        playField = GameEnvironment.CreatePlayField();
                        mines = GameEnvironment.PlantMines();
                        GameEnvironment.PrintPlayField(playField);
                        isMineActivated = false;
                        hasNewGameStarted = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (mines[playFieldRow, playFieldColumn] != '*')
                        {
                            if (mines[playFieldRow, playFieldColumn] == '-')
                            {
                                NextMove(playField, mines, playFieldRow, playFieldColumn);
                                cellsCounter++;
                            }
                            if (cellsCounter == MAX_NUMBER_OF_CELLS)
                            {
                                isGameWon = true;
                            }
                            else
                            {
                                GameEnvironment.PrintPlayField(playField);
                            }
                        }
                        else
                        {
                            isMineActivated = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }
                if (isMineActivated)
                {
                    GameEnvironment.PrintPlayField(mines);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", cellsCounter);

                    string playerName = Console.ReadLine();
                    Player playerScore = new Player(playerName, cellsCounter);

                    if (bestPlayers.Count < MAX_NUMBER_OF_BEST_PLAYERS)
                    {
                        bestPlayers.Add(playerScore);
                    }
                    else
                    {
                        for (int i = 0; i < bestPlayers.Count; i++)
                        {
                            if (bestPlayers[i].Points < playerScore.Points)
                            {
                                bestPlayers.Insert(i, playerScore);
                                bestPlayers.RemoveAt(bestPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    bestPlayers.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    bestPlayers.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    GameEnvironment.PrintLeaderBoard(bestPlayers);

                    playField = GameEnvironment.CreatePlayField();
                    mines = GameEnvironment.PlantMines();
                    cellsCounter = 0;
                    isMineActivated = false;
                    hasNewGameStarted = true;
                }

                if (isGameWon)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    GameEnvironment.PrintPlayField(mines);

                    Console.WriteLine("Daj si imeto, batka: ");
                    string playerName = Console.ReadLine();
                    Player playerScore = new Player(playerName, cellsCounter);
                    bestPlayers.Add(playerScore);
                    GameEnvironment.PrintLeaderBoard(bestPlayers);
                    playField = GameEnvironment.CreatePlayField();
                    mines = GameEnvironment.PlantMines();
                    cellsCounter = 0;
                    isGameWon = false;
                    hasNewGameStarted = true;
                }
            }

            while (inputCommand != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void NextMove(char[,] playField, char[,] mines, int playFieldRow, int playFieldColumn)
        {
            char numberOfMines = GameEnvironment.CalculateNumberOfMines(mines, playFieldRow, playFieldColumn);

            mines[playFieldRow, playFieldColumn] = numberOfMines;
            playField[playFieldRow, playFieldColumn] = numberOfMines;
        }
    }
}
