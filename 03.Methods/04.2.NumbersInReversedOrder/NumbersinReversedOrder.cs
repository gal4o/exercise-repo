using System;

namespace _04._2.NumbersInReversedOrder
{
    class NumbersinReversedOrder
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            GetDigits(input);
            
        }

        static void GetDigits(string input)
        {
            for (int i = input.Length-1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}
