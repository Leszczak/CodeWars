using System.Collections.Generic;
using System.Linq;
public class PokerHand
{
    private class Card
    {
        public char Value { get; private set; }
        public char Suit { get; private set; }
        public Card(string card)
        {
            Value = card[0];
            Suit = card[1];
        }
        public bool Equals(Card card)
        {
            if ((card.Value == 'X' || Value == card.Value)
                && (card.Suit == 'X' || Suit == card.Suit))
                return true;
            return false;
        }
    }
    public PokerHand(string hand)
    {
        List<Card> cards = hand.Split(' ')
                                .Select(s => new Card(s))
                                .ToList();

    }


}