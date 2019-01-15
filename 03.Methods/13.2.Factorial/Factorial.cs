using System;
using System.Numerics;
namespace _13._2.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFactorial(n);
        }

        static void PrintFactorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
