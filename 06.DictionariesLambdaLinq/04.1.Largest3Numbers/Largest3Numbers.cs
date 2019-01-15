using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._1.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            input = input.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
