using System;
using System.Collections.Generic;
using System.Linq;
public class PokerHand : IComparable<PokerHand>
{
    private class Card : IEquatable<Card>
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
    public int Value { get; private set; }
    public PokerHand(string hand)
    {
        List<Card> cards = hand.Split(' ')
                                .Select(s => new Card(s))
                                .ToList();
        //Royal flush=900, High card=0
        //When applicable card's worth is added, so single 5 > single 3
        //Royal flush
        if (cards.GroupBy(c => c.Suit)
                    .Any(g => g.Contains(new Card("AX"))
                                && g.Contains(new Card("QX"))
                                && g.Contains(new Card("KX"))
                                && g.Contains(new Card("JX"))
                                && g.Contains(new Card("TX"))))
            Value = 900;
        //Straight flush
        else if (false)
            Value = 800;
        //Four of a kind 	
        else if (cards.GroupBy(c => c.Value).Any(g => g.Contains(new Card("XS"))
                                                      && g.Contains(new Card("XH"))
                                                      && g.Contains(new Card("XD"))
                                                      && g.Contains(new Card("XC"))))
            Value = 700;
        //Full house
        else if (cards.GroupBy(c => c.Value).Any(g => g.Count() >= 3) //3
                    && cards.GroupBy(c => c.Value).Where(g => g.Count() >= 2).Count() >= 2) //2
            Value = 600;
        //Flush
        else if (false)
            Value = 500;
        //Straight
        else if (false)
            Value = 400;
        //Three of a kind
        else if (cards.GroupBy(c => c.Value).Any(g => g.Count() >= 3))
            Value = 300;
        //Two pairs
        else if (cards.GroupBy(c => c.Value).Where(g => g.Count() >= 2).Count() >= 2)
            Value = 200;
        //Pair
        else if (cards.GroupBy(c => c.Value).Any(g => g.Count() >= 2))
            Value = 100;
        //Highcard
        else
        {
            if (cards.Contains(new Card("AX")))
                Value = 14;
            else if (cards.Contains(new Card("KX")))
                Value = 13;
            else if (cards.Contains(new Card("QX")))
                Value = 12;
            else if (cards.Contains(new Card("JX")))
                Value = 11;
            else if (cards.Contains(new Card("TX")))
                Value = 10;
            else
                Value = cards.Where(c => c.Value > 49 && c.Value < 58)
                                .OrderByDescending(c => c.Value)
                                .First()
                                .Value;
        }
        Value += cards.OrderByDescending(c => c.Value).First().Value;
    }

    public int CompareTo(PokerHand other)
    {
        return Value.CompareTo(other.Value);
    }

    public static void Main(string[] args)
    {
    }
}