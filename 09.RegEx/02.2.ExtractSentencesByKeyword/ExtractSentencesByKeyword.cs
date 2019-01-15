using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._2.ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string[] input = Console.ReadLine()
                .Split(new char[] { '.', '?', '!' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>x.Trim())
                .ToArray();
            List<string> sentences = new List<string>();
            foreach (var item in input)
            {
                string[] words = item.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i]==pattern)
                    {
                        sentences.Add(item);
                        break;
                    }
                }
            }
            foreach (var sent in sentences)
            {
                Console.WriteLine(sent);
            }
        }
    }
}
