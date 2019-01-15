using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._1.MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"\b(?:0x)?[0-9A-F]+\b";
            var numbers = Regex.Matches(input, regex)
                .Cast<Match>().Select(x => x.Value)
                .ToArray();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
