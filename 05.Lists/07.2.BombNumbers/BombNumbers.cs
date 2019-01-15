using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._2.BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] tokkens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bomb = tokkens[0];
            int power = tokkens[1];
            //int bombNumb = input.IndexOf(bomb);
            List<int> output = input;
            while (output.Contains(bomb))
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == bomb)
                    {
                        for (int j = power; j >= 1; j--)
                        {
                            if (i + j <= output.Count - 1)
                                output.RemoveAt(i + j);
                        }
                        for (int j = 0; j <= power; j++)
                        {
                            if (i - j >= 0)
                                output.RemoveAt(i - j);
                        }
                    }

                }
            }
            int sum = 0;
            for (int i = 0; i < output.Count; i++)
            {
                sum += output[i];
            }
            Console.WriteLine(sum);
        }
    }
}
