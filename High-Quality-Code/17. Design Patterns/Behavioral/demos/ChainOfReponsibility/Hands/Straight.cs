using System;

namespace Poker.Hands
{
    class Straight:HandsChecker
    {
        private IPokerHandsChecker checker = new PokerHandsChecker();

        public override void CheckHand(IHand hand)
        {
            if(checker.IsStraight(hand))
            {
                Console.WriteLine("Hand {0} is straight",hand.ToString());
            }
            else if(this.Successor != null)
            {
                this.Successor.CheckHand(hand);
            }
        }
    }
}
