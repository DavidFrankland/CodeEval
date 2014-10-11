using System;

namespace PrimePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 999; i > 0; i--)
            {
                int firstDigit = ((i / 100) % 10);
                int lastDigit = i % 10;
                if (firstDigit != lastDigit) continue;
                if (!IsPrime(i)) continue;
                Console.WriteLine(i);
                break;
            }
            Console.ReadKey();
        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
