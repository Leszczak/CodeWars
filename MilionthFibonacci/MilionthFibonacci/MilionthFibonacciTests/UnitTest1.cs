using NUnit.Framework;
using System.Numerics;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestForSmall()
        {
            Assert.AreEqual(new BigInteger(0), Fibonacci.fib(0), "For 0 result should be 0");
            Assert.AreEqual(new BigInteger(1), Fibonacci.fib(1), "For 1 result should be 1");
            Assert.AreEqual(new BigInteger(1), Fibonacci.fib(2), "For 2 result should be 1");
            Assert.AreEqual(new BigInteger(2), Fibonacci.fib(3), "For 3 result should be 2");
            Assert.AreEqual(new BigInteger(3), Fibonacci.fib(4), "For 4 result should be 3");
        }

        [Test]
        public void TestForMid()
        {
            Assert.AreEqual(new BigInteger(2584), Fibonacci.fib(18), "For 18 result should be 2584");
            Assert.AreEqual(new BigInteger(4181), Fibonacci.fib(19), "For 19 result should be 4181");
            Assert.AreEqual(new BigInteger(6765), Fibonacci.fib(20), "For 20 result should be 6765");
        }

        [Test]
        public void TestForNeg()
        {
            Assert.AreEqual(new BigInteger(1), Fibonacci.fib(-1), "For -1 result should be 1");
            Assert.AreEqual(new BigInteger(-1), Fibonacci.fib(-2), "For -2 result should be -1");
            Assert.AreEqual(new BigInteger(2), Fibonacci.fib(-3), "For -3 result should be 2");
            Assert.AreEqual(new BigInteger(-3), Fibonacci.fib(-4), "For -4 result should be -3");
        }
    }
}