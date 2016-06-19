using System;
using System.IO;

namespace WordCount
{
    public class BookInfo
    {
        public static void OutputToFile(string fileIn, string fileOut)
        {
           var text = File.ReadAllText(fileIn);

            foreach (var word in WordCounter.CountWords(text))
            {
                var v = word.Value;
                var s = String.Format("{0} {1} {2}\n", word.Key, v, ParseIsPrime(v));

                File.AppendAllText(fileOut, s);
            } 
        }

        public static void Main(string[] args)
        {
            OutputToFile(args[0], args[1]);
        }

        private static string ParseIsPrime(int number)
        {
            return Prime.IsPrime(number) ? "prime" : "";
        }
    }
}
