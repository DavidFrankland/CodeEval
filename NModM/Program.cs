using System;
using System.IO;

namespace NModM
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                var strings = line.Split(',');
                var n = int.Parse(strings[0]);
                var m = int.Parse(strings[1]);
                while (n >= m) n -= m;
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
