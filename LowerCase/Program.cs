using System;
using System.IO;

namespace LowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                Console.WriteLine(line.ToLower());
            }

            Console.ReadKey();
        }
    }
}
