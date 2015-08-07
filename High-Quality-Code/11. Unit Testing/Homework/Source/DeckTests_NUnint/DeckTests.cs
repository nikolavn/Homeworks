using NUnit.Framework;
using Santase.Logic.Cards;
using System;
using System.Collections.Generic;

namespace DeckTests_NUnint
{
    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void TestDeckWithProperNUmberOfCardsIsCreated()
        {
            Deck sampleDeck = new Deck();
            var expectedCardsCount = 24;

            Assert.IsNotNull(sampleDeck, "Deck is not created");
            Assert.AreEqual(expectedCardsCount, sampleDeck.CardsLeft, "Generated deck doesn't have enough cards");
        }

        [Test]
        public void TestCreatedDeckIsShuffled()
        {
            Deck sampleDeck = new Deck();
            var initialCardsCount = sampleDeck.CardsLeft;
            var shuffledDeck = new List<Card>();

            for (int i = 0; i < sampleDeck.CardsLeft; i++)
            {
                shuffledDeck.Add(sampleDeck.GetNextCard());

            }

            shuffledDeck.Reverse();

            var matchingCardsCounter = 0;
            var testAmountOFCards = 10;
            var cardsFaceValue = Enum.GetValues(typeof(CardType));
            var cardsColor = Enum.GetValues(typeof(CardSuit));

            var unShuffledDeck = new List<Card>();

            foreach (CardType face in cardsFaceValue)
            {
                foreach (CardSuit suit in cardsColor)
                {
                    unShuffledDeck.Add(new Card(suit, face));
                }
            }


            for (int i = 1; i < testAmountOFCards; i++)
            {

                Console.Write(shuffledDeck[i]);
                Console.Write(unShuffledDeck[i]);
                if (shuffledDeck[i] == unShuffledDeck[i])
                {
                    matchingCardsCounter += 1;
                }
            }

            Console.Write(matchingCardsCounter);

            Assert.AreEqual(false, matchingCardsCounter > 4, "Generated deck is not shuffled");
        }

        [Test]
        public void TestMethodGetCardRemovesCardFromDeck()
        {
            Deck sampleDeck = new Deck();
            var initialCardsCount = sampleDeck.CardsLeft;

            sampleDeck.GetNextCard();

            Assert.AreEqual(initialCardsCount - 1, sampleDeck.CardsLeft, "Get card method doesn't remove card from deck");
        }

        [Test]
        [ExpectedException(typeof(Santase.Logic.InternalGameException))]
        public void TestMethodGetCardThrowsErrorWhenRemovingMoreCardsThanAvailable()
        {
            Deck sampleDeck = new Deck();
            var initialCardsCount = sampleDeck.CardsLeft;
            Card nextCard = sampleDeck.GetNextCard();

            for (int i = 0; i < initialCardsCount + 1; i++)
            {
                nextCard = sampleDeck.GetNextCard();
            }
        }

        [Test]
        public void TestMethodChangeTrumCardUpdatesTrumCardField()
        {
            Deck sampleDeck = new Deck();
            Card newTrumpCard = new Card(CardSuit.Heart, CardType.Nine);

            sampleDeck.ChangeTrumpCard(newTrumpCard);

            Assert.AreEqual(newTrumpCard, sampleDeck.GetTrumpCard, "Trump card field is not properly updated on trump card change");
        }

        [Test]
        public void TestMethodChangeTrumpCardUpdatesDeck()
        {
            Deck sampleDeck = new Deck();
            Card newTrumpCard = new Card(CardSuit.Heart, CardType.Nine);
            var initialCardsCount = sampleDeck.CardsLeft;
            sampleDeck.ChangeTrumpCard(newTrumpCard);
            var topCard = sampleDeck.GetNextCard();

            for (int i = 1; i < initialCardsCount; i++)
            {
                topCard = sampleDeck.GetNextCard();
            }

            Assert.AreEqual(newTrumpCard, topCard, "Deck is not properly updated on trump card change");
        }

        [Test]
        [TestCase(CardSuit.Heart, CardType.Queen)]
        [TestCase(CardSuit.Spade, CardType.Ace)]
        [TestCase(CardSuit.Diamond, CardType.Ten)]
        [TestCase(CardSuit.Club, CardType.King)]
        [TestCase(CardSuit.Spade, CardType.Jack)]
        public void TestParameterizedMethodChangeTrumpCardUpdatesTrumpCardFieldAndDeck(CardSuit suit, CardType faceValue)
        {
            Deck sampleDeck = new Deck();
            Card newTrumpCard = new Card(suit, faceValue);
            var initialCardsCount = sampleDeck.CardsLeft;
            sampleDeck.ChangeTrumpCard(newTrumpCard);
            var topCard = sampleDeck.GetNextCard();

            for (int i = 1; i < initialCardsCount; i++)
            {
                topCard = sampleDeck.GetNextCard();
            }

            Assert.AreEqual(newTrumpCard, topCard, "[From parameterized test]: Deck is not properly updated on trump card change");
            Assert.AreEqual(newTrumpCard, sampleDeck.GetTrumpCard, "[From parameterized test]: Trump card field is not properly updated on trump card change");
        }

        [Test]
        [TestCase(0)]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(22)]
        public void TestParameterizedMethodGetNextCardShouldRemoveCorrectNumberOfCards(int cardsToDraw)
        {
            Deck sampleDeck = new Deck();
            var initialCardsCount = sampleDeck.CardsLeft;

            for (int i = 0; i < cardsToDraw; i++)
            {
                sampleDeck.GetNextCard();
            }

            Assert.AreEqual(initialCardsCount - cardsToDraw, sampleDeck.CardsLeft, "[From parameterized test]: Deck is not updated when card is drawn");
        }
    }
}
