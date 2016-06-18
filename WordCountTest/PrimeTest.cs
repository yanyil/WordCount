using NUnit.Framework;

namespace WordCountAlt
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

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void Zero_And_One(int number)
        {
            Assert.False(Prime.IsPrime(number));
        }

        [Test]
        public void Number_Two()
        {
            Assert.True(Prime.IsPrime(2));
        }

        [Test]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(11)]
        [TestCase(13)]
        public void Small_Primes(int number)
        {
            Assert.True(Prime.IsPrime(number));
        }

        [Test]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        [TestCase(12)]
        public void Small_Composites(int number)
        {
            Assert.False(Prime.IsPrime(number));
        }

        [Test]
        public void Big_Prime()
        {
            Assert.True(Prime.IsPrime(2147483423));
        }

        [Test]
        public void Big_Composite()
        {
            Assert.False(Prime.IsPrime(2147483646));
        }
    }
}
