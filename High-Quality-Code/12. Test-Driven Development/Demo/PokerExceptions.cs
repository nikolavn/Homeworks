using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class PokerExceptions : Exception
    {
        public PokerExceptions(string message)
            :base(message)
        {

        }
    }
}
