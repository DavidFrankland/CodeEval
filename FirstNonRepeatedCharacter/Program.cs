using System;
using System.IO;
using System.Linq;

namespace FirstNonRepeatedCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                foreach (var c in line)
                {
                    if (line.Count(c1 => c1 == c) == 1)
                    {
                        Console.WriteLine(c);
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
