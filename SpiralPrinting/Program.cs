using System;
using System.IO;

namespace SpiralPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                var lineParts = line.Split(';');

                int rows = int.Parse(lineParts[0]);
                int cols = int.Parse(lineParts[1]);
                var values = lineParts[2].Split(' ');

                var board = new string[rows, cols];

                for (int i = 0; i < values.Length; i++)
                {
                    board[i / cols, i % cols] = values[i];
                }

                //Console.WriteLine(line);

                //Console.WriteLine("Input board:");
                //for (int r = 0; r < rows; r++)
                //{
                //    for (int c = 0; c < cols; c++)
                //    {
                //        Console.Write(board[r, c]);
                //    }
                //    Console.WriteLine();
                //}

                string outputLine = string.Empty;

                for (int layer = 0; layer < Math.Max(rows, cols); layer++)
                {
                    for (int c = layer; c < cols - layer; c++) outputLine = DoStuff(board, layer, c, outputLine, rows, cols);
                    for (int r = layer; r < rows - layer; r++) outputLine = DoStuff(board, r, cols - layer - 1, outputLine, rows, cols);
                    for (int c = cols - layer - 1; c >= layer; c--) outputLine = DoStuff(board, rows - layer - 1, c, outputLine, rows, cols);
                    for (int r = rows - layer - 1; r >= layer; r--) outputLine = DoStuff(board, r, layer, outputLine, rows, cols);
                }

                Console.WriteLine(outputLine);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static string DoStuff(string[,] board, int r, int c, string s, int rows, int cols)
        {
            if (r < 0 || c < 0 || r >= rows || c >= cols) return s;

            if (board[r, c] != null)
            {
                if (s.Length > 0) s += " ";
                s += board[r, c];
                board[r, c] = null;
            }
            return s;
        }
    }
}
