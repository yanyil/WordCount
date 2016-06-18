using System;
using System.IO;

namespace WordCount
{
    public class BookInfo
    {
        public static void Main(string[] args)
        {
            var text = File.ReadAllText(args[0]);

            foreach(var word in WordCounter.CountWords(text))
            {
                Console.WriteLine("{0} {1}", word.Key, word.Value);
            }
        }
    }
}
