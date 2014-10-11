using System;
using System.IO;
using System.Linq;

namespace SimpleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                var numbers = line.Split(' ').Select(decimal.Parse).ToList();

                numbers.Sort();

                var OutputLine = numbers
                    .Select(x => string.Format("{0:F3}", x))
                    .Aggregate((a, b) => a + " " + b);

                Console.WriteLine(OutputLine);
            }

            Console.ReadKey();
        }
    }
}
