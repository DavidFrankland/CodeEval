using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StackImplementation
{
    class Program
    {
        static readonly Stack<int> stack = new Stack<int>();

        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                var numbers = line.Split(' ').Select(int.Parse);

                foreach (var number in numbers)
                {
                    Push(number);
                }

                var sss = new List<string>();

                int? x = Pop().Value;

                while (x.HasValue)
                {
                    sss.Add(x.Value.ToString());
                    x = Pop();
                    x = Pop();
                }

                Console.WriteLine(sss.Aggregate((a,b) => a + " " + b));
            }

            Console.ReadKey();
        }

        private static void Push(int i)
        {
            stack.Push(i);
        }

        private static int? Pop()
        {
            return stack.Count > 0 ? (int?)stack.Pop() : null;
        }
    }
}
