using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._1.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> output = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]>=0)
                {
                    output.Add(input[i]);
                }
            }
            output.Reverse();
            if (output.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", output));
            }
        }
    }
}
