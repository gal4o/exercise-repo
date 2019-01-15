using System;

namespace _02._1.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                string swap = "";
                int j = rnd.Next(input.Length);
                swap = input[i];
                input[i] = input[j];
                input[j] = swap;
            }
            Console.WriteLine(string.Join("\n", input));
        }
    }
}
