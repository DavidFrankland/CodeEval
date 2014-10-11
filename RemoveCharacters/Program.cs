using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RemoveCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                var m = Regex.Match(line, @"(.+), (.+)");
                string s = m.Groups[1].ToString();
                string charsToRemove = m.Groups[2].ToString();

                foreach (var c in charsToRemove)
                {
                    s=s.Replace(c.ToString(), "");
                }

                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
