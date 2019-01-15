using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01._2.ConvertFromBase10ToBaseN
{
    class ConvertFromBase10ToBaseN
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split(" ").Select(BigInteger.Parse).ToArray();
            BigInteger baseNum = input[0];
            BigInteger number = input[1];
            List<BigInteger> output = new List<BigInteger>();
            while (number>0)
            {
                BigInteger rem = number %baseNum;
                output.Add(rem);
                number = number / baseNum;
            }
            output.Reverse();
            foreach (var item in output)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
