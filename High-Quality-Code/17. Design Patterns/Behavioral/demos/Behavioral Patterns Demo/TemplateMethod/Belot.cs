using System;
using System.Threading;

namespace TemplateMethod
{
    class Belot : CardGame
    {
        public Belot(int numberOfPlayers)
            : base(numberOfPlayers)
        {

        }

        protected override void InitializeGame()
        {
            for (int i = 0; i < NumberOfPlayers; i++)
            {
                Console.WriteLine("Deal 5 cards to Player {0}", i + 1);
            }
            Thread.Sleep(2000);
            Console.WriteLine("Make announces...");
            Thread.Sleep(2000);
            for (int i = 0; i < NumberOfPlayers; i++)
            {
                Console.WriteLine("Deal 3 cards to Player {0}", i + 1);
            }
        }

        protected override void PlayTurn()
        {
            Console.WriteLine("Play turns...");
            Thread.Sleep(2000);
        }

        public override void PlayGame()
        {
            InitializeGame();
            PlayTurn();
            base.EndGame();
        }
    }
}
