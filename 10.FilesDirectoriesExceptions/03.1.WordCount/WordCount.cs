using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._1.WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("text.txt").ToLower()
                .Split(new char[] {'\n', '\r', ' ','.',',','!','?','-'},
                StringSplitOptions.RemoveEmptyEntries);
            var wordCount = new Dictionary<string, int>();
            foreach (string word in words)
            {
                wordCount[word] = 0;
            }
            foreach (string word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }
            wordCount = wordCount.OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            List<string> output = new List<string>();
            foreach (var word in wordCount)
            {
                string resultLine =  $"{word.Key} = {word.Value}";
                output.Add(resultLine);
            }
            File.WriteAllLines("output.txt", output);

        }
    }
}
