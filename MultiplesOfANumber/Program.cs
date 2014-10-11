using System;
using System.IO;

namespace MultiplesOfANumber
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
                int x = int.Parse(numbers[0]);
                int n = int.Parse(numbers[1]);

                int i = n;
                while (i < x) i += n;
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
