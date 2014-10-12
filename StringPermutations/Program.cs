using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StringPermutations
{
    class Program
    {
        private static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                var list = MyFunc(line);
                list.Sort(StringComparer.Ordinal);
                Console.WriteLine(list.Aggregate((a, b) => a + "," + b));
            }
            Console.ReadKey();
        }

        private static List<string> MyFunc(string s)
        {
            var result = new List<string>();

            if (s.Length == 1) return new List<string> { s };

            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i].ToString();
                string left = s.Substring(0, i);
                string right = s.Substring(i + 1);
                var subStrings = MyFunc(left + right);
                result.AddRange(subStrings.Select(x => c + x));
            }

            return result;
        }
    }
}
