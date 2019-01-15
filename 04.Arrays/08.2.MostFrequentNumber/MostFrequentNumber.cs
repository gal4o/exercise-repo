using System;
using System.Linq;
namespace _08._2.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int maxCount = 0;
            int frequent = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i]==input[j])
                    {
                        count++;
                        if (count>maxCount)
                        {
                            maxCount = count;
                            frequent = input[i];
                        }
                    }
                }
            }
            Console.WriteLine(frequent);
        }
    }
}
