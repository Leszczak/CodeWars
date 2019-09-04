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
        public void Small()
        {
            Assert.AreEqual(0, Parser.ParseInt("zero"));
            Assert.AreEqual(1, Parser.ParseInt("one"));
            Assert.AreEqual(2, Parser.ParseInt("two"));
            Assert.AreEqual(3, Parser.ParseInt("three"));
            Assert.AreEqual(4, Parser.ParseInt("four"));
            Assert.AreEqual(5, Parser.ParseInt("five"));
            Assert.AreEqual(6, Parser.ParseInt("six"));
            Assert.AreEqual(7, Parser.ParseInt("seven"));
            Assert.AreEqual(8, Parser.ParseInt("eight"));
            Assert.AreEqual(9, Parser.ParseInt("nine"));
            Assert.AreEqual(10, Parser.ParseInt("ten"));
            Assert.AreEqual(11, Parser.ParseInt("eleven"));
            Assert.AreEqual(12, Parser.ParseInt("twelve"));
        }

        [Test]
        public void Teen()
        {
            Assert.AreEqual(13, Parser.ParseInt("thirteen"));
            Assert.AreEqual(15, Parser.ParseInt("fifteen"));
            Assert.AreEqual(16, Parser.ParseInt("sixteen"));
            Assert.AreEqual(19, Parser.ParseInt("nineteen"));
        }

        [Test]
        public void Ties()
        {
            Assert.AreEqual(20, Parser.ParseInt("twenty"));
            Assert.AreEqual(50, Parser.ParseInt("fifty"));
            Assert.AreEqual(90, Parser.ParseInt("ninety"));
            Assert.AreEqual(33, Parser.ParseInt("thirty-three"));
            Assert.AreEqual(67, Parser.ParseInt("sixty-seven"));
            Assert.AreEqual(99, Parser.ParseInt("ninety-nine"));
        }

        [Test]
        public void Big()
        {
            Assert.AreEqual(246, 
                            Parser.ParseInt("two hundred forty-six"));
            Assert.AreEqual(1111111, 
                            Parser.ParseInt("one million one hundred eleven thousands one hundred and eleven"));
        }
    }
}