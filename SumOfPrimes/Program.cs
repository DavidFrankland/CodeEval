using System;

namespace SumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int count = 0;
            int test = 2;

            while (count < 1000) 
            {
                if (IsPrime(test))
                {
                    total += test;
                    count++;
                }

                test++;
            }

            Console.WriteLine(total);
            Console.ReadKey();
        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
