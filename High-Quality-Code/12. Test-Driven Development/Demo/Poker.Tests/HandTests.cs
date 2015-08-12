using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class HandTests
    { 
        [TestMethod]
        public void TestHandToString_First()
        {
            string expectedHand = "K♣J♥10♠6♥2♠";

            Card firstCard = new Card(CardFace.King, CardSuit.Clubs);
            Card secondCard = new Card(CardFace.Jack, CardSuit.Hearts);
            Card thirdCard = new Card(CardFace.Ten, CardSuit.Spades);
            Card fourthCard = new Card(CardFace.Six, CardSuit.Hearts);
            Card fifthCard = new Card(CardFace.Two, CardSuit.Spades);

            Hand sampleHand = new Hand(new Card[] { firstCard, secondCard, thirdCard, fourthCard, fifthCard });

            Assert.AreEqual(expectedHand, sampleHand.ToString());
        }

        [TestMethod]
        public void TestHandToString_Second()
        {
            string expectedHand = "4♣Q♥A♠9♦6♠";

            Card firstCard = new Card(CardFace.Four, CardSuit.Clubs);
            Card secondCard = new Card(CardFace.Queen, CardSuit.Hearts);
            Card thirdCard = new Card(CardFace.Ace, CardSuit.Spades);
            Card fourthCard = new Card(CardFace.Nine, CardSuit.Diamonds);
            Card fifthCard = new Card(CardFace.Six, CardSuit.Spades);

            Hand sampleHand = new Hand(new Card[] { firstCard, secondCard, thirdCard, fourthCard, fifthCard });

            Assert.AreEqual(expectedHand, sampleHand.ToString());
        }
    }
}
