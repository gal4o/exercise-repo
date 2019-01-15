using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._1.TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<string> output = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                int a = input[i];
                for (int j = i+1; j < input.Length; j++)
                {
                    int b = input[j];
                    for (int k = 0; k < input.Length; k++)
                    {
                        int c = input[k];
                        if (a+b==c)
                        {
                            output.Add($"{a} + {b} == {c}");
                        }                        
                    }
                }
            }
            if (output.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = 0; i < output.Count; i++)
                {
                    Console.WriteLine(output[i]);
                }
            }
        }
    }
}
