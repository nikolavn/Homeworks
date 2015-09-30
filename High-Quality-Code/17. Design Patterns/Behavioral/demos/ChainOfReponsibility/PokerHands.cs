using Poker.Hands;
using System;


namespace Poker
{
    public class PokerHands
    {
        public void EstimateHand(IHand hand)
        {
            HandsChecker highCardHand = new HighCard();
            HandsChecker onePairHand = new OnePair();
            HandsChecker twoPairsHand = new TwoPairs();
            HandsChecker threeOfAKindHand = new ThreeOfAKind();
            HandsChecker straightHand = new Straight();
            HandsChecker flushHand = new Flush();
            HandsChecker fullHouseHand = new FullHouse();
            HandsChecker fourOfAkindHand = new FourOfAKind();
            HandsChecker straightFlushHand = new StraightFlush();

            straightFlushHand.SetSuccessor(fourOfAkindHand);
            fourOfAkindHand.SetSuccessor(fullHouseHand);
            fullHouseHand.SetSuccessor(flushHand);
            flushHand.SetSuccessor(straightHand);
            straightHand.SetSuccessor(threeOfAKindHand);
            threeOfAKindHand.SetSuccessor(twoPairsHand);
            twoPairsHand.SetSuccessor(onePairHand);
            onePairHand.SetSuccessor(highCardHand);

            straightFlushHand.CheckHand(hand);
        }
    }
}
