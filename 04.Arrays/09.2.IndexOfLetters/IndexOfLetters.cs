using System;

namespace _09._2.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} -> {input[i]-97}");
            }
        }
    }
}
