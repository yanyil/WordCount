using NUnit.Framework;

namespace WordCount
{
    [TestFixture]
    public class PrimeTest
    {
        [Test]
        [TestCase(-1)]
        [TestCase(-2)]
        [TestCase(-3)]
        [TestCase(-5)]
        [TestCase(-6)]
        public void Negatives(int number)
        {
            Assert.False(Prime.IsPrime(number));
        }
    }
}