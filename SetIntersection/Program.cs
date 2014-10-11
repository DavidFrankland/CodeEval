using System;
using System.IO;
using System.Linq;

namespace SetIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                var lists = line.Split(';');
                var list1 = lists[0].Split(',').ToList();
                var list2 = lists[1].Split(',').ToList();

                var q1 = list1.Where(list2.Contains).ToList();
                var q2 = list2.Where(list1.Contains).ToList();

                var intersection = q1.Concat(q2).Distinct().ToList();

                if (intersection.Any())
                {
                    Console.WriteLine(intersection.Aggregate((a, b) => a + ',' + b));
                }
                else
                {
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
