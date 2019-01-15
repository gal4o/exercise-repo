using System;
using System.Numerics;
namespace _06._2.PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(long n)
        {
            if (n == 0)
            {
                return false; 
            }
            else if (n == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n) ; i++)
                {
                    if ((n % i == 0) && (n != i))
                    {
                        return false;
                    }
                }
            }
            return true ;
        }
    }
}
