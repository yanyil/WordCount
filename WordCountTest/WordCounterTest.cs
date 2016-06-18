using NUnit.Framework;
using System.Collections.Generic;

namespace WordCountAlt
{
	[TestFixture]
	public class WordCounterTest
	{
		[Test]
		public void Empty_String()
		{
			Assert.That(WordCounter.CountWords(""), Is.Empty);
		}

		[Test]
		public void Count_One_Word()
		{
			var counts = new Dictionary<string, int> {
				{ "word", 1 }
			};

			Assert.That(WordCounter.CountWords("word"), Is.EqualTo(counts));
		}

		[Test]
		public void Count_Each_Word_Once()
		{
			var counts = new Dictionary<string, int> {
				{ "each", 1 },
				{ "word", 1 },
				{ "once", 1 }
			};

			Assert.That(WordCounter.CountWords("each word once"), Is.EqualTo(counts));
		}

        [Test]
        public void Count_Multiple_Occurrences()
        {
            var input = "multiple occurrences multiple multiple occurrences";
            var counts = new Dictionary<string, int> {
                { "multiple", 3 },
                { "occurrences", 2 }
            };

            Assert.That(WordCounter.CountWords(input), Is.EqualTo(counts));
        }

        [Test]
        public void Ignore_Punctuation()
        {
            var counts = new Dictionary<string, int> {
                { "ignore", 1 }
            };

            Assert.That(WordCounter.CountWords("ignore? :!!.@#$%^&"), Is.EqualTo(counts));
        }

        [Test]
        public void Ignore_Capitalisation()
        {
            var counts = new Dictionary<string, int> {
                { "no", 1 },
                { "caps", 1 }
            };

            Assert.That(WordCounter.CountWords("No CAPS"), Is.EqualTo(counts));
        }
	}
}
