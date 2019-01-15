using System;
using System.Linq;
namespace _03._2.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] first = new int[input.Length / 2];
            int[] second = new int[input.Length / 2];
            int[] sum = new int[first.Length];

            for (int i = 0; i < input.Length/4; i++)
            {
                first[i] = input[input.Length / 4-1 - i];
            }
            for (int i = 0; i < input.Length / 4; i++)
            {
                first[input.Length/4 + i] = input[input.Length - 1 - i];
            }
            for (int i = 0; i < input.Length/2; i++)
            {
                second[i] = input[input.Length / 4 + i];
            }
            for (int i = 0; i < first.Length; i++)
            {
                sum[i] = first[i] + second[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
