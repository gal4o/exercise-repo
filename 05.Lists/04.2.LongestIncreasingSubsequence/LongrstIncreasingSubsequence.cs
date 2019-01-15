using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._2.LongestIncreasingSubsequence
{
    class LongrstIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ")
                .Select(int.Parse).ToList();
            List<int> lis = FindLIS(input);
            Console.WriteLine(string.Join(" ", lis));
        }

        static List<int> FindLIS(List<int> seqence)
        {
            List<int> length = new List<int>();
            List<int> prev = new List<int>();
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < seqence.Count; i++)
            {
                length.Add(1);
                prev.Add(-1);
                for (int j = 0; j < i; j++)
                {
                    if (seqence[j]<seqence[i]&&length[j]>=length[i])
                    {
                        length[i] = 1 + length[j];
                            prev[i] = j;
                    }
                }
                if (length[i]>maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }
            List<int> longestSequence = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestSequence.Add(seqence[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            longestSequence.Reverse();
            return longestSequence;
        }
    }
}
