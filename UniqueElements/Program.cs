using System;
using System.IO;
using System.Linq;

namespace UniqueElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                Console.WriteLine(line.Split(',').Distinct().Aggregate((a, b) => a + ',' + b));
            }

            Console.ReadKey();
        }
    }
}
