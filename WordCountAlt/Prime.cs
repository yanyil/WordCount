using System;
using System.Linq;
namespace WordCountAlt
{
    public static class Prime
    {
        public static bool IsPrime(int number)
        {
            return number > 1 && Enumerable.Range(2, (int)Math.Sqrt(number) - 1)
                                           .All(divisor => number % divisor != 0);
        }
    }
}
