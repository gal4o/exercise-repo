using System;

namespace _02._1.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int count = 0;
            string mutch = Console.ReadLine().ToLower();
            int index = input.IndexOf(mutch);
            while (index!=-1)
            {
                count++;
                index = input.IndexOf(mutch, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
