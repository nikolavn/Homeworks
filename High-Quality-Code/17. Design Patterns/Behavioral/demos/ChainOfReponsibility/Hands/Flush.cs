using System;

namespace Poker.Hands
{
    class Flush:HandsChecker
    {
        private IPokerHandsChecker checker = new PokerHandsChecker();

        public override void CheckHand(IHand hand)
        {
            if(checker.IsFlush(hand))
            {
                Console.WriteLine("Hand {0} is flush",hand.ToString());
            }
            else if(this.Successor !=null)
            {
                this.Successor.CheckHand(hand);
            }
        }
    }
}
