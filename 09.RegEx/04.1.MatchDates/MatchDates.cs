using System;
using System.Text.RegularExpressions;

namespace _04._1.MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reg = @"(?<day>\d{2})(?<sep>[.\-\/])(?<month>[A-Z]{1}[a-z]{2})\2(?<year>\d{4})";
            var dates = Regex.Matches(input, reg);
            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
