using System;
using System.Text.RegularExpressions;

namespace _01._2.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s)([a-zA-Z0-9][\w\-.]+[a-zA-Z0-9]*)@[a-zA-Z0-9]+([-a-zA-Z]+)*(\.[a-zA-z0-9]+)+(?=[,.])";
            var emails = Regex.Matches(input, pattern);
            foreach (Match mail in emails)
            {
                Console.WriteLine("{0}", mail.Value);
            }
        }
    }
}
