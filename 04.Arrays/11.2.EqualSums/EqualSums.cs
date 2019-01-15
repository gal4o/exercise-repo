using System;
using System.Linq;

namespace _11._2.EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            bool haveEqual = false;
            for (int i = 0; i < input.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j= 0; j < i; j++)
                {
                    leftSum += input[j];
                }
                for (int j = i+1; j < input.Length; j++)
                {
                    rightSum += input[j];
                }
                if (leftSum == rightSum)
                {
                    haveEqual = true;
                    Console.WriteLine(i);
                }                
            }
            if (!haveEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
