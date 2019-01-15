using System;
using System.IO;
using System.Linq;

namespace _02._1.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            var numbLines = lines.Select((line, index) => $"{index + 1}.{line}");
            File.WriteAllLines("output.txt", numbLines);

        }
    }
}
