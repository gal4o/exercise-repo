using System;
using System.Linq;
namespace _09._3.JumpAround
{
    class JumpAround
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum = input[0];
            int p = 0;

            while (p>=0&&p<input.Length)
            {
                if (input[p]+p<input.Length)
                {
                    p += input[p];
                    sum += input[p];
                }
                else if (p-input[p]>=0)
                {
                    p -= input[p];
                    sum += input[p];
                }
                else
                {
                    Console.WriteLine(sum);
                    break;
                }
            }

        }
    }
}
