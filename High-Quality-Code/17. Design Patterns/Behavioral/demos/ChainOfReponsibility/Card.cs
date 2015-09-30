using System;
using System.Collections.Generic;

namespace Poker
{
    public class Card : ICard, IComparable<Card>
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }


        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string cardFace = ConvertCardFaceToString();
            char cardSuit = ConvertCardSuitToChar();

            string completeCard = cardFace + cardSuit;

            return completeCard;
        }

        private string ConvertCardFaceToString()
        {
            string cardFace;

            if ((int)this.Face <= 10)
            {
                cardFace = ((int)this.Face).ToString();
            }
            else
            {
                cardFace = (this.Face.ToString()[0]).ToString();
            }

            return cardFace;
        }

        private char ConvertCardSuitToChar()
        {
            char cardSuit;

            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    cardSuit = '\u2663';
                    break;
                case CardSuit.Diamonds:
                    cardSuit = '\u2666';
                    break;
                case CardSuit.Hearts:
                    cardSuit = '\u2665';
                    break;
                case CardSuit.Spades:
                    cardSuit = '\u2660';
                    break;
                default:
                    throw new InvalidOperationException("Invalid suit " + this.Suit);
            }
            return cardSuit;
        }

        public override bool Equals(object obj)
        {
            Card otherCard = obj as Card;

            if (otherCard == null)
            {
                return false;
            }

            return this.Face == otherCard.Face && this.Suit == otherCard.Suit;
        }

        public override int GetHashCode()
        {
            return ((int)this.Face * Enum.GetNames(typeof(CardSuit)).Length + (int)this.Suit);
        }

        public int CompareTo(Card otherCard)
        {
            throw new NotImplementedException();
        }
    }
}
