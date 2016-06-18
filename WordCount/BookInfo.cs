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
                var v = word.Value;
                var s = String.Format("{0} {1} {2}\n", word.Key, v, ParseIsPrime(v));

                File.AppendAllText(args[1], s);
            }
        }

        private static string ParseIsPrime(int number)
        {
            return Prime.IsPrime(number) ? "prime" : "";
        }
    }
}
