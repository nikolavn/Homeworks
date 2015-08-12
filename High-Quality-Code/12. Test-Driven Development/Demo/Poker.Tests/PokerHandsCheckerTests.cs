using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class PokerHandsCheckerTests
    {
        [TestMethod]
        [ExpectedException(typeof(PokerExceptions))]
        public void TestHandWithNull()
        {
            new PokerHandsChecker().IsValidHand(null);
        }

        [TestMethod]
        public void TestHandWithLessCards()
        {
            Hand sampleHand = new Hand(new Card[] {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts) });

            bool validHand = new PokerHandsChecker().IsValidHand(sampleHand);

            Assert.AreEqual(false, validHand);
        }

        [TestMethod]
        public void TestHandWithMoreCards()
        {
            Hand sampleHand = new Hand(new Card[] {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Clubs)});

            bool validHand = new PokerHandsChecker().IsValidHand(sampleHand);

            Assert.AreEqual(false, validHand);
        }

        [TestMethod]
        public void TestHandValidWithDuplicateCards()
        {
            Hand sampleHand = new Hand(new Card[] {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Diamonds)});

            bool validHand = new PokerHandsChecker().IsValidHand(sampleHand);

            Assert.AreEqual(false, validHand);
        }

        [TestMethod]
        public void TestHandIsFlush_ValidFlush()
        {
            Hand sampleHand = new Hand(new Card[] {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)});

            bool isFlush = new PokerHandsChecker().IsFlush(sampleHand);

            Assert.AreEqual(true, isFlush);
        }

        [TestMethod]
        public void TestHandIsFlush_StraightFlush()
        {
            Hand sampleHand = new Hand(new Card[] {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs)});

            bool isFlush = new PokerHandsChecker().IsFlush(sampleHand);

            Assert.AreEqual(false, isFlush);
        }

        [TestMethod]
        public void TestHandIsFourOfAKind_ValidFourOfAKind()
        {
            Hand sampleHand = new Hand(new Card[] {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Clubs)});

            bool isFourOfAKind = new PokerHandsChecker().IsFlush(sampleHand);

            Assert.AreEqual(false, isFourOfAKind);
        }

        // TODO: Create tests for all methods in PokerHandsChecker
    }
}
