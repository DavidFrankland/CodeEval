using System;
using System.IO;

namespace RightmostChar
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                var strings=line.Split(',');
                var s = strings[0];
                var t = strings[1];
                Console.WriteLine(s.LastIndexOf(t));
            }

            Console.ReadKey();
        }
    }
}
