using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._1.CountRealNumbers
{
    class CountRealnumbers
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            SortedDictionary<double, int> output = new SortedDictionary<double, int>();
            foreach (var num in input)
            {
                if (!output.ContainsKey(num))
                {
                    output.Add(num, 1);
                }
                else
                {
                    output[num]++;
                }
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
