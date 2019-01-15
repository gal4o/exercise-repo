using System;
using System.Collections.Generic;

namespace _07._2.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(", ", FindPrimes(start,end)));
        }

        static List<int> FindPrimes(int start,int end)
        {
            List<int> primes = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;                
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
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if ((n % i == 0) && (n != i))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
