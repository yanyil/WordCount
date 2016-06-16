using NUnit.Framework;
using System.Collections.Generic;

namespace WordCount
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
	}
}

