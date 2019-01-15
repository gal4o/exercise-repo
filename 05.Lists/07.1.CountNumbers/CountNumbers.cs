using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._1.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            input.Sort();            
            int count = 1;
            for (int i = 0; i < input.Count-1; i++)
            {
                    if (input[i] == input[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{input[i]} -> {count}");
                        count = 1;
                    }
            }
            Console.WriteLine($"{input[input.Count-1]} -> {count}");
        }
    }
}
