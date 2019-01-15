using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace _06._2.ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            Regex pattern = new Regex(@"\b[A-Za-z]\w+");
            List<Match> usernames = new List<Match>();
            
            foreach (var item in input)
            {
                if (pattern.IsMatch(item))
                {
                    Match username = pattern.Match(item);
                    usernames.Add(username);
                }
            }
            int count = 0;
            int maxCount = 0;
            List<Match> validUsernames = new List<Match>();
            for (int i = 1; i < usernames.Count; i++)
            {
                count = usernames[i-1].Length + usernames[i].Length;
                if (count>maxCount)
                {
                    maxCount = count;
                    validUsernames.Clear();
                    validUsernames.Add(usernames[i - 1]);
                    validUsernames.Add(usernames[i]);
                }
            }
            foreach (Match item in validUsernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
