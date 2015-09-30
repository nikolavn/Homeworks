using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Hands
{
    class FourOfAKind:HandsChecker
    {
        private IPokerHandsChecker checker = new PokerHandsChecker();

        public override void CheckHand(IHand hand)
        {
            if(checker.IsFourOfAKind(hand))
            {
                Console.WriteLine("Hand {0} is four of a kind",hand.ToString());
            }
            else if (this.Successor != null)
            {
                this.Successor.CheckHand(hand);
            }
        }
        
    }
}
