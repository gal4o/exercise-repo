using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._1.OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(" ");
            Dictionary<string, int> forOutput = new Dictionary<string, int>();
            List<string> output = new List<string>();
            foreach (var item in input)
            {
                if (!forOutput.ContainsKey(item))
                {
                    forOutput.Add(item, 1);
                }
                else
                {
                    forOutput[item]++;
                }
            }
            foreach (var item in forOutput)
            {
                if (item.Value%2!=0)
                {
                    output.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
