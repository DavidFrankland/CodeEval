using System;
using System.IO;
using System.Linq;

namespace ClosestPair
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]).ToArray();
            int arrayIndex = 0;
            int numPoints = int.Parse(lines[arrayIndex++]);

            while (numPoints > 0)
            {
                var xCoords = new int[numPoints];
                var yCoords = new int[numPoints];

                for (int i = 0; i < numPoints; i++)
                {
                    var coords = lines[arrayIndex++].Split(' ');
                    xCoords[i] = int.Parse(coords[0]);
                    yCoords[i] = int.Parse(coords[1]);
                }

                var closestDistance = 10000.0;
                var foundCloser = false;

                for (int i = 0; i < numPoints; i++)
                {
                    for (int j = i + 1; j < numPoints; j++)
                    {
                        var x = xCoords[i] - xCoords[j];
                        var y = yCoords[i] - yCoords[j];
                        var distance = Math.Sqrt(x * x + y * y);
                        if (distance < closestDistance)
                        {
                            closestDistance = distance;
                            foundCloser = true;
                        }
                    }
                }

                Console.WriteLine(foundCloser ? string.Format("{0:f4}", closestDistance) : "INFINITY");

                numPoints = int.Parse(lines[arrayIndex++]);
            }

            Console.ReadKey();
        }
    }
}
