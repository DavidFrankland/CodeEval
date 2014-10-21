using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MarsNetworks
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(args[0]);

            foreach (var line in lines)
            {
                var probeStrings = line.Split(' ');
                int numProbes = probeStrings.Length;
                var xCoords = new int[numProbes];
                var yCoords = new int[numProbes];

                for (int i = 0; i < numProbes; i++)
                {
                    var coords = probeStrings[i].Split(',');
                    xCoords[i] = int.Parse(coords[0]);
                    yCoords[i] = int.Parse(coords[1]);
                }

                var distances = new List<double>();

                for (int i = 0; i < numProbes; i++)
                {
                    for (int j = i + 1; j < numProbes; j++)
                    {
                        var x = xCoords[i] - xCoords[j];
                        var y = yCoords[i] - yCoords[j];
                        var distance = Math.Sqrt(x * x + y * y);
                        distances.Add(distance);
                    }
                }

                distances.Sort();

                //foreach (var distance in distances)
                //{
                //    Console.WriteLine(string.Format("d:{0}", distance));
                //}

                var totalDistance = distances.Take(numProbes - 1).Sum();

                //Console.WriteLine(totalDistance);

                var integerDistance = (int)Math.Ceiling(totalDistance);

                Console.WriteLine(integerDistance);
            }

            Console.ReadKey();
        }
    }
}
