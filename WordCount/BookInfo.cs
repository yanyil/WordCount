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

                Console.WriteLine("{0} {1} {2}", word.Key, v, ParseIsPrime(v));
            }
        }

        private static string ParseIsPrime(int number)
        {
            return Prime.IsPrime(number) ? "prime" : "";
        }
    }
}
