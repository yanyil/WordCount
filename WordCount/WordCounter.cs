using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCount
{
	public static class WordCounter
	{
		public static IDictionary<string, int> CountWords(string inputText)
		{
			var counts = new Dictionary<string, int>();

            if (inputText.Length == 0) return counts;

            Match wordMatch = Regex.Match(inputText, @"\w+");

            while(wordMatch.Success)
            {
                counts.Add(wordMatch.Value, 1);
                wordMatch = wordMatch.NextMatch();
            }

			return counts;
		}
	}
}

