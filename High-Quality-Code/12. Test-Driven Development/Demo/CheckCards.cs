using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class CheckCards
    {
        public bool AreSameSuit(IHand pokerHand)
        {
            return pokerHand.Cards.GroupBy(card => card.Suit).Count() == 1;
        }

        public int FaceRepetitionsCount(IHand pokerHand)
        {
            return pokerHand.Cards.GroupBy(card => card.Face).Select(group => group.Count()).Max();
        }

        public int NumberOfPairs(IHand pokerHand)
        {
            return pokerHand.Cards.GroupBy(card => card.Face).Select(group => group.Count()).Where(rep => rep == 2).Count();
        }

        public bool AreConsecutiveCards(IHand pokerHand)
        {
            var uniqueFaceValues = pokerHand.Cards.Select(card => card.Face).Distinct();

            bool areConsecutive = ((uniqueFaceValues.Max() - uniqueFaceValues.Min()) == 4);

            if (!areConsecutive)
            {
                bool isHighestFive = (uniqueFaceValues.Take(4).Max() == CardFace.Five);
                bool isLowestAce = (uniqueFaceValues.Max() == CardFace.Ace);

                areConsecutive = isHighestFive && isLowestAce;
            }

            return areConsecutive;
        }
    }
}
