using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._2.MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int count = 1;
            int countMax = 0;
            List<int> increasing = new List<int>();
            List<int> tryBigIncr = new List<int>();
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > input[i - 1])
                {
                    if (tryBigIncr.Count==0)
                    {
                        tryBigIncr.Add(input[i - 1]);
                    }
                    tryBigIncr.Add(input[i]);
                    count++;
                    if (count > countMax)
                    {
                        countMax = count;
                        increasing = tryBigIncr; ;
                    }
                }
                else
                {
                    count = 1;
                    tryBigIncr = new List<int>();
                }
            }            
            Console.WriteLine(string.Join(" ", increasing));
        }
    }
}
