using System;

namespace Poker.Hands
{
    class HighCard:HandsChecker
    {
        private IPokerHandsChecker checker = new PokerHandsChecker();

        public override void CheckHand(IHand hand)
        {
            if(checker.IsHighCard(hand))
            {
                Console.WriteLine("Hand {0} is high card",hand.ToString());
            }
            else if(this.Successor != null)
            {
                this.Successor.CheckHand(hand);
            }
        }
    }
}
