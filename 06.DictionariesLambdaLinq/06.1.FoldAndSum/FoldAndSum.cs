using System;
using System.Linq;

namespace _06._1.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] first = new int[input.Length / 2];
            int[] second = new int[input.Length / 2];
                first = input.Take(input.Length / 4).Reverse().Concat(input.Reverse().Take(input.Length / 4)).ToArray();
                second = input.Skip(input.Length / 4).Take(input.Length / 2).ToArray();
            for (int i = 0; i < input.Length/2; i++)
            {
                Console.Write(first[i]+second[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
