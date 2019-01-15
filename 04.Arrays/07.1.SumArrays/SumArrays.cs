using System;
using System.Linq;
namespace _07._1.SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] output = new int[Math.Max(input1.Length,input2.Length)];
            for (int i = 0; i < Math.Max(input1.Length,input2.Length); i++)
            {
                output[i] = input1[i%input1.Length] + input2[i%input2.Length];
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
