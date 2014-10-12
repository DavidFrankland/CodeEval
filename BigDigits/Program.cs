using System;
using System.IO;

namespace BigDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var digits = new[]
            {
                "-**----*--***--***---*---****--**--****--**---**--",
                "*--*--**-----*----*-*--*-*----*-------*-*--*-*--*-",
                "*--*---*---**---**--****-***--***----*---**---***-",
                "*--*---*--*-------*----*----*-*--*--*---*--*----*-",
                "-**---***-****-***-----*-***---**---*----**---**--",
                "--------------------------------------------------",
            };

            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                foreach (var digitRow in digits)
                {
                    foreach (var c in line)
                    {
                        if (c < '0' || c > '9') continue;
                        var x = int.Parse(c.ToString());
                        Console.Write(digitRow.Substring(x * 5, 5));
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
