using System;
using System.IO;
using System.Linq;

namespace ReverseWords
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line)) continue;
                Console.WriteLine(line.Split(' ').Reverse().Aggregate((a, b) => a + " " + b));
            }

            Console.ReadKey();
        }
    }
}
