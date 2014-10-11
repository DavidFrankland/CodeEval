using System;
using System.IO;

namespace BitPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line)) continue;

                var numbers = line.Split(',');
                int n = int.Parse(numbers[0]);
                int p1 = int.Parse(numbers[1]);
                int p2 = int.Parse(numbers[2]);

                var bit1 = (n & (1 << (p1 - 1))) > 0;
                var bit2 = (n & (1 << (p2 - 1))) > 0;
                bool b = (bit1 == bit2);
                Console.WriteLine(b.ToString().ToLower());
            }

            Console.ReadKey();
        }
    }
}
