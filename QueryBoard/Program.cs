using System;
using System.IO;

namespace QueryBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);
            const int BOARD_SIZE = 256;
            var board = new int[256, 256];
            int total = 0;

            foreach (var line in lines)
            {
                var lineParts = line.Split(' ');
                var command = lineParts[0];

                int row;
                int col;
                int value;

                switch (command)
                {
                    case "SetRow":
                        row = int.Parse(lineParts[1]);
                        value = int.Parse(lineParts[2]);
                        for (int i = 0; i < BOARD_SIZE; i++) board[row, i] = value;
                        break;

                    case "SetCol":
                        col = int.Parse(lineParts[1]);
                        value = int.Parse(lineParts[2]);
                        for (int i = 0; i < BOARD_SIZE; i++) board[i, col] = value;
                        break;

                    case "QueryRow":
                        row = int.Parse(lineParts[1]);
                        total = 0;
                        for (int i = 0; i < BOARD_SIZE; i++) total += board[row, i];
                        Console.WriteLine(total);
                        break;

                    case "QueryCol":
                        col = int.Parse(lineParts[1]);
                        total = 0;
                        for (int i = 0; i < BOARD_SIZE; i++) total += board[i, col];
                        Console.WriteLine(total);
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
