using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CalculateDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                var m = Regex.Match(line, @"\((-?\d+), (-?\d+)\) \((-?\d+), (-?\d+)\)");
                var x1 = int.Parse(m.Groups[1].ToString());
                var y1 = int.Parse(m.Groups[2].ToString());
                var x2 = int.Parse(m.Groups[3].ToString());
                var y2 = int.Parse(m.Groups[4].ToString());
                var x = x1 - x2;
                var y = y1 - y2;
                var distance = Math.Sqrt(x * x + y * y);
                Console.WriteLine(distance);
            }
            Console.ReadKey();
        }
    }
}
