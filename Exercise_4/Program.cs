using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Exercise_4
{
    class Program
    {
        static List<string> FilterFile(string root, Predicate<string> predicate)
        {
            var files = new List<string>();
            
            foreach (var file in Directory.GetFiles(root))
            {
                if (predicate(file))
                {
                    files.Add(file);
                }
            }
            return files;
        }
        static void Main(string[] args)
        {
            FilterFile(@"D:\Tumblers", x => x.EndsWith("")).ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
