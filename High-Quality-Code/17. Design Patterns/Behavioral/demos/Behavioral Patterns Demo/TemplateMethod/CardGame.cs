using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class CardGame
    {

        protected CardGame(int numberOfPlayers)
        {
            this.NumberOfPlayers = numberOfPlayers;
        }

        protected int NumberOfPlayers{ get; private set; }

        protected abstract void InitializeGame();
        protected abstract void PlayTurn();
        private bool HasEnded()
        {
            Random gen = new Random();
            int randNumber = gen.Next(2);

            if (randNumber >= 1)
            {
                return true;
            }

            return false;
        }
        protected void EndGame()
        {
            Console.WriteLine("Game has {0}", HasEnded() ? "ended" : "not ended");
        }
        public abstract void PlayGame();
    }
}
