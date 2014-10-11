using System;
using System.IO;

namespace HexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                Console.WriteLine(Convert.ToInt32(line, 16));
            }

            Console.ReadKey();
        }
    }
}
