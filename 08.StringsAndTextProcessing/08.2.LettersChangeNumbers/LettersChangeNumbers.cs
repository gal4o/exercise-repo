using System;
using System.Numerics;

namespace _08._2.LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double realOutput = 0;
            foreach (string tryMath in input)
            {
                double num = double.Parse(tryMath.Substring(1, tryMath.Length - 2));
                double output = 0;
                if (tryMath[0] >= 'A' && tryMath[0] <= 'Z')
                {
                    output = num /(double)(tryMath[0] - 64);
                }
                else if (tryMath[0] >= 'a' && tryMath[0] <= 'z')
                {
                    output = num * (double)(tryMath[0] - 96);
                }
                if (tryMath[tryMath.Length - 1] >= 'A' && tryMath[tryMath.Length - 1] <= 'Z')
                {
                    output -= (tryMath[tryMath.Length - 1] - 64);
                }
                else if (tryMath[tryMath.Length - 1] >= 'a' && tryMath[tryMath.Length - 1] <= 'z')
                {
                    output += (tryMath[tryMath.Length - 1] - 96);
                }
                realOutput += output;
            }
            Console.WriteLine("{0:f2}",realOutput);
        }
    }
}
