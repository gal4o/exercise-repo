using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._1.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            bool haveEquals = true ;
            while (haveEquals)
            {
                for (int i = 0; i < input.Count - 1; i++)
                {
                haveEquals = false;
                if (input[i] == input[i + 1])
                    {
                        input[i] += input[i + 1];
                        input.RemoveAt(i + 1);
                        haveEquals = true;
                        i = 0;
                        break;
                    }
                }
                if (input.Count==1)
                {
                    //Console.WriteLine(input[0]);
                    haveEquals = false;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}