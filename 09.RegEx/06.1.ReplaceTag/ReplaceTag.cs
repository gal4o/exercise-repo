using System;
using System.Text.RegularExpressions;

namespace _06._1.ReplaceTag
{
    class ReplaceTag
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reg = @"\<a href=(.*)>(.*?)<\/a>";
            string rep = @"[URL href=$1]$2[/URL]";
            while (input!="end")
            {
                string result = Regex.Replace(input, reg,rep);
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}
