using System;

namespace Poker.Hands
{
    class OnePair:HandsChecker
    {
        private IPokerHandsChecker checker = new PokerHandsChecker();

        public override void CheckHand(IHand hand)
        {
            if(checker.IsOnePair(hand))
            {
                Console.WriteLine("Hand {0} is one pair",hand.ToString());
            }
            else if(this.Successor != null)
            {
                this.Successor.CheckHand(hand);
            }
        }
    }
}
