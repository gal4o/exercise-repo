using System;
using System.Linq;
namespace _05._1.RoundingNumbersAwayFromZero
{
    class RoundingNumbersAweyFromZero
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                output[i] =(int) Math.Round(input[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} => {output[i]}");
            }
        }
    }
}
