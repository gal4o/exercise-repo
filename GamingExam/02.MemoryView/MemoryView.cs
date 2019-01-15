using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MemoryView
{
    class MemoryView
    {
        static void Main(string[] args)
        {
            //predwaritelno split, za da wzima powe4e ot 1 br!!

            string input = Console.ReadLine();
            string pattern = @"32656 19759 32763 0 ";
            while (!input.Contains("Visual Studio crash"))
            {
                input += ' ' + Console.ReadLine();
            }
            input = input.Remove(input.Length - 19, 19);
            while (input.Contains(pattern))
            {
                int indAfterPat = input.IndexOf(pattern) + 20;
                string match = input.Substring(indAfterPat, 2);
                int count = int.Parse(match.ToString());
                string search = input.Substring
                        ((indAfterPat + 4));
                List<string> symbols = search.Split(' ')
                        .ToList();
                string decoding = "";
                for (int i = 0; i < count; i++)
                {
                   decoding += (char)int.Parse(symbols[i]);
                }
                Console.WriteLine(decoding);
                input = input.Remove(input.IndexOf(pattern), 2);
            }
        }
    }
}
