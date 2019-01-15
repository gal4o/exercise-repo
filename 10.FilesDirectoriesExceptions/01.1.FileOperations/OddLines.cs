using System;
using System.IO;
using System.Linq;

namespace _01._1.FileOperations
{
    class OddLines
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            var oddLines = lines.Where((line, index) => index % 2 == 1);
            File.WriteAllLines("odd-lines.txt",oddLines);            
        }
    }
}
