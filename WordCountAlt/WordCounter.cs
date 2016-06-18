using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace WordCountAlt
{
    public static class WordCounter
    {
        public static IDictionary<string, int> CountWords(string inputText)
        {
            return Regex.Split(inputText, @"\W+")
                        .Where(x => x != string.Empty)
                        .GroupBy(x => x.ToLower())
                        .ToDictionary(x => x.Key, x => x.Count());
        }
    }
}
