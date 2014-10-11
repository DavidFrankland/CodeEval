using System;
using System.IO;
using System.Linq;

namespace ArmstrongNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                var number = int.Parse(line);
                var numberOfDigits = line.Length;
                int total = line
                    .Select(c => int.Parse(c.ToString()))
                    .Select(digit => (int)Math.Pow(digit, numberOfDigits))
                    .Sum();
                Console.WriteLine(number == total);
            }

            Console.ReadKey();
        }
    }
}
