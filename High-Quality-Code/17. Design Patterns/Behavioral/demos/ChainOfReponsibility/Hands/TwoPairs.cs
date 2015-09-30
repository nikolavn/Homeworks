using System;

namespace Poker.Hands
{
    class TwoPairs:HandsChecker
    {
        private IPokerHandsChecker checker = new PokerHandsChecker();

        public override void CheckHand(IHand hand)
        {
            if(checker.IsTwoPair(hand))
            {
                Console.WriteLine("Hand {0} is two pairs",hand.ToString());
            }
            else if(this.Successor != null)
            {
                this.Successor.CheckHand(hand);
            }
        }
    }
}
