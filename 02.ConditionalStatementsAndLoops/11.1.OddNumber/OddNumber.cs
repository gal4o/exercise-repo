﻿using System;

namespace _11._1.OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            while (input%2==0)
            {
                Console.WriteLine("Please write an odd number.");
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(input)}");
        }
    }
}
