using System;
using System.IO;
using System.Linq;

namespace FindAWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                var lineParts = line.Split('|');
                var s = lineParts[0];
                var key = lineParts[1].Trim().Split(' ').Select(int.Parse);

                foreach (var index in key)
                {
                    Console.Write(s[index - 1]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
