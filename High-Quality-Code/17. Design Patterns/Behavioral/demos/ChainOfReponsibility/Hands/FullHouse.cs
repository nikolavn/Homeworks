using System;

namespace Poker.Hands
{
    class FullHouse:HandsChecker
    {
        private IPokerHandsChecker checker = new PokerHandsChecker();

        public override void CheckHand(IHand hand)
        {
            if (checker.IsFullHouse(hand))
            {
                Console.WriteLine("Hand {0} is full house",hand.ToString());
            }
            else if(this.Successor != null)
            {
                this.Successor.CheckHand(hand);
            }
        }
    }
}
