using System;
using System.IO;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                int i = int.Parse(line);
                Console.WriteLine(FibonacciNumber(i));
            }

            Console.ReadKey();
        }

        private static int FibonacciNumber(int i)
        {
            if (i == 0) return 0;
            if (i == 1) return 1;
            return FibonacciNumber(i - 1) + FibonacciNumber(i - 2);
        }
    }
}
