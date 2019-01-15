using System;

namespace _09._1.MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{input} X {i} = {input*i}");
            }
        }
    }
}
