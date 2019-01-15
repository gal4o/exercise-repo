using System;
using System.Linq;
namespace _01._3.ArrayStatistics
{
    class ArrayStatistics
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            long min = input[0];
            long max = input[0];
            long sum = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                    min = Math.Min(input[i], min);               
                    max = Math.Max(input[i], max);                
                sum += input[i];
            }
            double avg =(double) sum / input.Length;
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {avg}");
            
        }
    }
}
