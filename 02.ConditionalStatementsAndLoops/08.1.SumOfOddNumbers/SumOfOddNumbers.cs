using System;

namespace _08._1.SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int integer = 1;
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine(integer);
                sum+= integer;
                integer += 2;                
            }
            Console.WriteLine("Sum: {0}",sum);
        }
    }
}
