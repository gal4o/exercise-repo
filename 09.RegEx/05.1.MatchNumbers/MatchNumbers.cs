using System;
using System.Text.RegularExpressions;

namespace _05._1.MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reg = @"(^|(?<=\s))-?\d*(\.\d*)?($|(?=\s))";
            var numbers = Regex.Matches(input, reg);
            foreach (Match number in numbers)
            {
                Console.Write(number.Value+" ");
            }
            Console.WriteLine();
        }
    }
}
