using System;

namespace _09._2.MelrahShake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();
            while (input.Contains(pattern))
            {
                int firstIndex = input.IndexOf(pattern);
                input = input.Remove(firstIndex, pattern.Length);
                if (input.Contains(pattern))
                {
                    int lastIndex = input.LastIndexOf(pattern);
                    input = input.Remove(lastIndex, pattern.Length);
                }
                Console.WriteLine("Shaked it.");
                pattern = pattern.Remove(pattern.Length / 2, 1);
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}
