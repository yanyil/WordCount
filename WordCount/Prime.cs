namespace WordCount
{
    public static class Prime
    {
        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;

            for (var i = 3; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}

