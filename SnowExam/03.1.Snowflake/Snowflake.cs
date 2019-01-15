using System;
using System.Text.RegularExpressions;

namespace _03._1.Snowflake
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            string firstSurface = Console.ReadLine();
            string firstMantle = Console.ReadLine();
            string all = Console.ReadLine();
            string lastMantle = Console.ReadLine();
            string lastSurface = Console.ReadLine();
            string pattern = @"([^a-zA-Z0-9]+)([0-9_]+)([a-zA-Z]+)[0-9_]+[^a-zA-Z0-9]+";
            Regex regex = new Regex(pattern);
            Regex regexSurf = new Regex(@"[^a-zA-Z0-9]+$");
            Regex regexMantle = new Regex(@"[0-9_]+$");
            if (regexSurf.IsMatch(firstSurface)&&regexSurf.IsMatch(lastSurface))
            {
                if (regexMantle.IsMatch(firstMantle)&&regexMantle.IsMatch(lastMantle))
                {
                    if (regex.IsMatch(all))
                    {
                        Match matchAll = regex.Match(all);
                        Console.WriteLine("Valid");
                        Console.WriteLine($"{matchAll.Groups[3].Length}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }            
        }
    }
}
