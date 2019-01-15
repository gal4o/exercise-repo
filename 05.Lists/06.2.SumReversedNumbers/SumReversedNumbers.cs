using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._2.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ").ToList();
            int sum = 0;
            foreach (var num in input)
            {
                string newNum = "";
                for (int i = num.Length-1; i >= 0; i--)
                {
                    newNum += num[i];
                }
                sum += int.Parse(newNum);
            }
            Console.WriteLine(sum);
        }
    }
}
