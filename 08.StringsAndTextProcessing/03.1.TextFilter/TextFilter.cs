using System;

namespace _03._1.TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] ban = Console.ReadLine().Split(", ");
            string input = Console.ReadLine();
            foreach (var word in ban)
            {
                if (input.Contains(word))
                {
                    input = input.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(input);
        }
    }
}
