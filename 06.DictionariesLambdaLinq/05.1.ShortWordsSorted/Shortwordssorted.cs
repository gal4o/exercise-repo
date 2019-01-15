using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._1.ShortWordsSorted
{
    class Shortwordssorted
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(new char[] {'.',',',':',';','(',')','[',']','"','\'','\\','/','!','?',' '},StringSplitOptions.RemoveEmptyEntries);
            input = input.Where(x => x.Length < 5).OrderBy(x => x).Distinct().ToArray();
            Console.WriteLine(string.Join(", ", input));            
        }
    }
}
