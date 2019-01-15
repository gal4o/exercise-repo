using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._2.ReverseCharacters
{
    class Reversecharacters
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char thrit = char.Parse(Console.ReadLine());
            Console.Write($"{thrit}{second}{first}");
        }
    }
}
