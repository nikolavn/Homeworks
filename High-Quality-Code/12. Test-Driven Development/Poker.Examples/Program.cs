using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poker;

namespace Poker.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand sampleHand = new Hand(new Card[] {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs)});

            var checker = new PokerHandsChecker();

            Console.WriteLine(checker.IsFlush(sampleHand));
            Console.WriteLine(checker.IsStraight(sampleHand));
            Console.WriteLine(checker.IsStraightFlush(sampleHand));

            Console.WriteLine(sampleHand.Cards.Distinct().Count());
        }
    }
}
