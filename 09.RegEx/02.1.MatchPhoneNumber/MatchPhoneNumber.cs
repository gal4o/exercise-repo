using System;
using System.Text.RegularExpressions;

namespace _02._1.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string regex = @"[s]?\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";
            var phoneMatches = Regex.Matches(numbers, regex);
            //foreach (Match phone in phoneMatches)
            //{
                Console.WriteLine(string.Join(", ",phoneMatches));
            //}
            Console.WriteLine();
        }
    }
}
