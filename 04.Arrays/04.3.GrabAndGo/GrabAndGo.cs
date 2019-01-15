using System;
using System.Linq;
namespace _04._3.GrabAndGo
{
    class GrabAndGo
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            long sum = 0;
            bool haveOccurrence = false;
            for (int i = input.Length-1; i >=0; i--)
            {
                if (input[i]==num)
                {
                    for (int j = i-1; j >=0; j--)
                    {
                        sum += input[j];
                    }
                    Console.WriteLine(sum);
                    haveOccurrence = true;
                    break;
                }
            }
            if (!haveOccurrence)
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
