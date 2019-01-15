using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._1.SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine().Split(" ").Select(decimal.Parse).ToList();
            input.Sort();
            Console.WriteLine(string.Join(" <= ", input));
        }
    }
}
