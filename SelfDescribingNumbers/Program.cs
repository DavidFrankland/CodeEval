using System;
using System.IO;
using System.Linq;

namespace SelfDescribingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                bool b = true;

                for (int place = 0; place < line.Length; place++)
                {
                    var c = line[place];
                    var digit = int.Parse(c.ToString());
                    var times = line.Count(x => int.Parse( x.ToString()) == place);
                    b = b && (times == digit);

                }
                Console.WriteLine(b ? 1 : 0);
            }

            Console.ReadKey();
        }
    }
}
