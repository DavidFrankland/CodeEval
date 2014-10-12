using System;
using System.IO;
using System.Linq;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = File.ReadLines(args[0]).ToList().Select(int.Parse);

            var maximum = values.Max();

            var sieve = new bool[maximum];

            for (int i = 0; i < maximum; i++)
            {
                sieve[i] = (i >= 2);
            }

            for (int i = 2; i < maximum; i++)
            {
                if (sieve[i])
                {
                    for (int j = i * 2; j < maximum; j += i)
                    {
                        sieve[j] = false;
                    }
                }
            }

            foreach (var value in values)
            {
                bool startOfLine = true;

                for (int i = 0; i < value; i++)
                {
                    if (sieve[i])
                    {
                        if (!startOfLine) Console.Write(",");
                        Console.Write(i);
                        startOfLine = false;
                    }
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
