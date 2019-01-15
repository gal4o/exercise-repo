using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._1.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
            foreach (var word in input)
            {
                int countLow = 0;
                int countUp = 0;
                foreach (var alphabet in word)
                {                    
                    if (alphabet>='a' && alphabet<='z')
                    {
                        countLow++;
                    }
                    else if (alphabet>='A' && alphabet<='Z')
                    {
                        countUp ++;
                    }                    
                }
                if (word.Length==countLow)
                {
                    lowerCase.Add(word);
                }
                else if (word.Length==countUp)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
