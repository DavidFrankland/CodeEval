using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HappyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                int i = int.Parse(line);

                var visitedNumbers = new List<int> { i };

                while (i != 1)
                {
                    i = i
                        .ToString()
                        .Select(c => int.Parse(c.ToString()))
                        .Select(x => x * x)
                        .Sum();

                    if (visitedNumbers.Contains(i))
                    {
                        Console.WriteLine(0);
                        break;
                    }

                    visitedNumbers.Add(i);
                }

                if (i == 1)
                {
                    Console.WriteLine(1);
                }
            }

            Console.ReadKey();
        }
    }
}
