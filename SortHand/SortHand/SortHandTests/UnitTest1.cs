using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValueCalculation()
        {
            Assert.AreEqual(900, new PokerHand("TH JH QH KH AH").Value);
            Assert.AreEqual(800, new PokerHand("3S 4S 5S 6S 7S").Value);
            Assert.AreEqual(700, new PokerHand("KS KH KD KC AC").Value);
            Assert.AreEqual(600, new PokerHand("KS KH KD 3S 3H").Value);
            Assert.AreEqual(500, new PokerHand("KS QS TS 7S 2S").Value);
            Assert.AreEqual(400, new PokerHand("AS 2H 3C 4D 5S").Value);
            Assert.AreEqual(300, new PokerHand("5S 5H 5C 2H 7H").Value);
            Assert.AreEqual(200, new PokerHand("5S 5H 4S 4H 2S").Value);
            Assert.AreEqual(100, new PokerHand("5S 5H 7H 9S KC").Value);
            Assert.AreEqual( 13, new PokerHand("KS JC TC 7H 2D").Value);//king
        }
    }
}