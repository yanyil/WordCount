using System.Collections.Generic;

namespace WordCount
{
	public static class WordCounter
	{
		public static IDictionary<string, int> CountWords(string inputText)
		{
			var counts = new Dictionary<string, int>();

			if (inputText.Length != 0)
			{
				counts.Add(inputText, 1);
			}

			return counts;
		}
	}
}

