using System;

namespace _04._2.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            string first = input[0];
            string second = input[1];
            long sum = 0;
            int minLenght = Math.Min(first.Length, second.Length);

            for (int i = 0; i < minLenght; i++)
            {
                long multi = first[i] * second[i];
                sum += multi;
            }

            if (first.Length != second.Length)
            {
                if (minLenght == first.Length)
                {
                    for (int i = first.Length; i < second.Length; i++)
                    {
                        sum += second[i];
                    }
                }
                else
                {
                    for (int i = second.Length; i < first.Length; i++)
                    {
                        sum += first[i];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
