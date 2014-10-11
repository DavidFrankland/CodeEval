using System;
using System.IO;
using System.Linq;

namespace SumOfIntegersFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);
            int total = lines.Sum(line => int.Parse(line));
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
