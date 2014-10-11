using System;
using System.IO;

namespace TrailingString
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                var q = line.Split(',');
                Console.WriteLine(q[0].EndsWith(q[1]) ? 1 : 0);
            }
            Console.ReadKey();
        }
    }
}
