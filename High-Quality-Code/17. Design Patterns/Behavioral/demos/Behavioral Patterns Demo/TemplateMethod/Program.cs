using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(new string('=',20));
            CardGame belotGame = new Belot(4);
            belotGame.PlayGame();

            Console.WriteLine(new string('=', 20));
            CardGame pokerGame = new TexasHoldemPoker(7);
            pokerGame.PlayGame();
        }
    }
}
