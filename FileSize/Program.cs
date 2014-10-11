using System;
using System.IO;

namespace FileSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var fi = new FileInfo(args[0]);
            Console.WriteLine(fi.Length);
            Console.ReadKey();
        }
    }
}
