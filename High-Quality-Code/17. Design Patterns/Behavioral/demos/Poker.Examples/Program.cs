namespace Poker.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand[] sampleHands = { new Hand(new Card[] {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs)}),
                new Hand(new Card[] {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs)}),
                new Hand(new Card[] {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Hearts)}),
                new Hand(new Card[] {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs)}),
                new Hand(new Card[] {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs)})
            };

            PokerHands listOfHands = new PokerHands();

            foreach (var hand in sampleHands)
            {
                listOfHands.EstimateHand(hand);
            }
           
        }
    }
}
