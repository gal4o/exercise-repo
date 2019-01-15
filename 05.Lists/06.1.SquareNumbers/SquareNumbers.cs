using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._1.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> output = new List<int>();
            foreach (var num in input)
            {
                for (int i = 1; i <= Math.Sqrt(num); i++)
                {                    
                    if (Math.Sqrt(num)== i)
                    {
                        output.Add(num);
                    }
                }
            }
            output.Sort((x,y) => y.CompareTo(x));
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
