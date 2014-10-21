using System;
using System.IO;
using System.Text.RegularExpressions;

namespace EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern;
            //pattern = @"^[A-Za-z0-9._+!#$%&'*/=?^-]*\@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)*\.[a-zA-Z]+$"; // 95
            //pattern = @"^[A-Za-z0-9._+-]*\@[a-zA-Z0-9]([a-zA-Z0-9-])+\.[a-zA-Z]+$"; // 80
            //pattern = @"^[A-Za-z0-9._+-]*\@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)*\.[a-zA-Z]+$"; // 95
            //pattern = @"^[A-Za-z0-9._+-]*\@[a-zA-Z](-?[a-zA-Z0-9]+)*(\.[a-zA-Z](-?[a-zA-Z0-9]+)*)*\.[a-zA-Z]+$"; // 95
            //pattern = @"^[A-Za-z0-9._+-]*\@[a-zA-Z0-9](-?[a-zA-Z0-9]+)*(\.[a-zA-Z](-?[a-zA-Z0-9]+)*)*\.[a-zA-Z]+$"; // 95
            
            pattern = @"^[A-Za-z0-9._+-]*\@[a-zA-Z0-9](-?[a-zA-Z0-9]+)*(\.[a-zA-Z0-9](-?[a-zA-Z0-9]+)*)*\.[a-zA-Z]+$"; // 95

            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                Console.WriteLine(Regex.IsMatch(line, pattern).ToString().ToLower());
            }

            Console.ReadKey();
        }
    }
}
