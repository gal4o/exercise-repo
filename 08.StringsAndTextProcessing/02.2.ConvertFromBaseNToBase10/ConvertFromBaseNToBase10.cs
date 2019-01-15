using System;
using System.Collections.Generic;
using System.Numerics;

namespace _02._2.ConvertFromBaseNToBase10
{
    class ConvertFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int baseNum = int.Parse(input[0]);
            string number = input[1];
            BigInteger output = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int num = int.Parse(number[number.Length - 1 - i].ToString());
                output += num * ((BigInteger)Math.Pow(baseNum, i));
            }
            Console.WriteLine(output);
        }
    }
}
