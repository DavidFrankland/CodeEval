using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line) continue;

                var numbers = line.Split(' ');
                var a = int.Parse(numbers[0]);
                var b = int.Parse(numbers[1]);
                var n = int.Parse(numbers[2]);

                bool startOfLine = true;
                for (int i = 1; i <= n; i++)
                {
                    bool fizz = false;
                    bool buzz = false;

                    if (i % a == 0)
                    {
                        if (!startOfLine)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("F");
                        fizz = true;
                        startOfLine = false;
                    }

                    if (i % b == 0)
                    {
                        if (!startOfLine && !fizz)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("B");
                        buzz = true;
                        startOfLine = false;
                    }

                    if (!fizz && !buzz)
                    {
                        if (!startOfLine)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(i);
                        startOfLine = false;
                    }
                }
                Console.WriteLine();
            }
        }
        Console.ReadKey();
    }
}