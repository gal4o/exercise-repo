using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._1.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> output = new List<string>();
            foreach (var word in input)
            {
                string reversed =new string( word.Reverse().ToArray());
                if (word == reversed)
                {
                    if (!output.Contains(word))
                    {
                        output.Add(word);
                    }
                }
            }
            output.Sort();
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
