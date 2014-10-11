using System;

namespace MultiplicationTables
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 12; x++)
            {
                string line = string.Empty;

                for (int y = 1; y <= 12; y++)
                {
                    line += (x * y).ToString().PadLeft(4);
                }

                Console.WriteLine(line.Trim());
            }

            Console.ReadKey();
        }
    }
}
