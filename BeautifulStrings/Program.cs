using System;
using System.IO;
using System.Linq;

namespace BeautifulStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                var occurrences = new int[26].ToList();

                foreach (var c in line)
                {
                    var lowerCaseChar = c.ToString().ToLower()[0];
                    if (lowerCaseChar < 'a' || lowerCaseChar > 'z') continue;
                    int index = lowerCaseChar - 'a';
                    occurrences[index]++;
                }

                occurrences.Sort();

                int total = 0;

                for (int i = 0; i < 26; i++)
                {
                    total += occurrences[i] * (i + 1);
                }

                Console.WriteLine(total);
            }

            Console.ReadKey();
        }
    }
}
