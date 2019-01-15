using System;

namespace _06._2.IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            for (int i = Math.Min(first,second); i <= Math.Max(first,second); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
