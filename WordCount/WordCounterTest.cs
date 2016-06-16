using NUnit.Framework;

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
	}
}

