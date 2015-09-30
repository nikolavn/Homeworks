using System;
using System.Threading;

namespace TemplateMethod
{
    class TexasHoldemPoker:CardGame
    {
        public TexasHoldemPoker(int numberOfPlayers) 
            : base(numberOfPlayers)
        {

        }

        protected override void InitializeGame()
        {
            for (int i = 0; i < NumberOfPlayers; i++)
            {
                Console.WriteLine("Deal 1 cards to Player {0}", i + 1);
            }
            Thread.Sleep(1000);
            for (int i = 0; i < NumberOfPlayers; i++)
            {
                Console.WriteLine("Deal 1 cards to Player {0}", i + 1);
            }
            Thread.Sleep(1000);
        }

        protected override void PlayTurn()
        {
            Console.WriteLine("Make announces");
            Thread.Sleep(1000);
            Console.WriteLine("Deal 3 cards to board");
            Thread.Sleep(500);
            Console.WriteLine("Deal turn to board");
            Thread.Sleep(500);
            Console.WriteLine("Deal river to board");
            Thread.Sleep(500);
        }

        public override void PlayGame()
        {
            InitializeGame();
            PlayTurn();
            base.EndGame();
        }
    }
}
