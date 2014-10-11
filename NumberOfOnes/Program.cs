using System;
using System.IO;

namespace NumberOfOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                int x = int.Parse(line);
                int count = 0;

                while (x > 0)
                {
                    if ((x & 1) > 0) count++;
                    x /= 2;
                }

                Console.WriteLine(count);
            }
            Console.ReadKey();
        }
    }
}
