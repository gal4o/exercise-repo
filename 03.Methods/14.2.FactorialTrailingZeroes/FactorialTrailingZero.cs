using System;
using System.Numerics;

namespace _14._2.FactorialTrailingZeroes
{
    class FactorialTrailingZero
    {
        
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                PrintZerosCount(GetFactorial(n));
            }

            static BigInteger GetFactorial(int n)
            {
                BigInteger factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        
        static void PrintZerosCount(BigInteger n)
        {
            int count = 0;
            int digit = 0;
            while (digit==0)
            {
                if (n%10==0)
                {
                    count++;
                }
                digit =(int)( n % 10);
                n = n / 10;
            }
            Console.WriteLine(count);
        }
    }
}
