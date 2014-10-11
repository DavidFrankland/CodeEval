using System;
using System.IO;
using System.Linq;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                int total = line.Sum(c => int.Parse(c.ToString()));
                Console.WriteLine(total);
            }

            Console.ReadKey();
        }
    }
}
