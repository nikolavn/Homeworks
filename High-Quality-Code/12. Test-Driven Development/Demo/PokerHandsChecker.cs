using System;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        private void ThrowExceptionIfInvalidHand(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                throw new PokerExceptions("Hand {0} is not valid");
            }
        }

        private CheckCards cardsChecker = new CheckCards();

        public bool IsValidHand(IHand hand)
        {
            if (object.Equals(hand, null))
            {
                throw new PokerExceptions("Hand is null");
            }

            return hand.Cards.Distinct().Count() == 5;
        }

        public bool IsStraightFlush(IHand hand)
        {
            return cardsChecker.AreConsecutiveCards(hand) && cardsChecker.AreSameSuit(hand);
        }

        public bool IsFourOfAKind(IHand hand)
        {
            ThrowExceptionIfInvalidHand(hand);

            return cardsChecker.FaceRepetitionsCount(hand) == 4;
        }

        public bool IsFullHouse(IHand hand)
        {
            ThrowExceptionIfInvalidHand(hand);

            return IsThreeOfAKind(hand) && IsOnePair(hand);
        }

        public bool IsFlush(IHand hand)
        {
            ThrowExceptionIfInvalidHand(hand);

            return cardsChecker.AreSameSuit(hand) && !cardsChecker.AreConsecutiveCards(hand);
        }

        public bool IsStraight(IHand hand)
        {
            ThrowExceptionIfInvalidHand(hand);

            return cardsChecker.AreConsecutiveCards(hand) && !cardsChecker.AreSameSuit(hand);
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            ThrowExceptionIfInvalidHand(hand);

            return cardsChecker.FaceRepetitionsCount(hand) == 3;
        }

        public bool IsTwoPair(IHand hand)
        {
            ThrowExceptionIfInvalidHand(hand);

            return cardsChecker.NumberOfPairs(hand) == 2;
        }

        public bool IsOnePair(IHand hand)
        {
            ThrowExceptionIfInvalidHand(hand);

            return cardsChecker.NumberOfPairs(hand) == 1;
        }

        public bool IsHighCard(IHand hand)
        {
            ThrowExceptionIfInvalidHand(hand);

            return IsValidHand(hand);
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

    }
}
