using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Poker.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestAceOfSpades()
        {
            string expectedCard = "A♠";
            Card aceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);

            Assert.AreEqual(expectedCard, aceOfSpades.ToString());
        }

        [TestMethod]
        public void TestKingOfHearts()
        {
            string expectedCard = "K♥";
            Card kingOfHearts = new Card(CardFace.King, CardSuit.Hearts);

            Assert.AreEqual(expectedCard, kingOfHearts.ToString());
        }

        [TestMethod]
        public void TestTenOfDiamonds()
        {
            string expectedCard = "10♦";
            Card tenOfDiamonds = new Card(CardFace.Ten, CardSuit.Diamonds);

            Assert.AreEqual(expectedCard, tenOfDiamonds.ToString());
        }

        [TestMethod]
        public void TestSevenOfClubs()
        {
            string expectedCard = "7♣";
            Card sevenOfClubs = new Card(CardFace.Seven, CardSuit.Clubs);

            Assert.AreEqual(expectedCard, sevenOfClubs.ToString());
        }

        [TestMethod]
        public void TestNineOfHearts()
        {
            string expectedCard = "9♥";
            Card nineOfHearts = new Card(CardFace.Nine, CardSuit.Hearts);

            Assert.AreEqual(expectedCard, nineOfHearts.ToString());
        }
    }
}
