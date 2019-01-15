using System;
using System.Text.RegularExpressions;

namespace _01._1.MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string regex = @"\b[A-Z][a-z]+[A-Z][a-z]+\b";
            MatchCollection matchedNames = Regex.Matches(names, regex);
            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value+" ");
            }
            Console.WriteLine();
        }
    }
}
