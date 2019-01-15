using System;

namespace _09._1.MultiplyEvensByOdds
{
    class MultiplyByOdds
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine("{0}", GetMultipleOfEvensAndOdds(n));

        }

        static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return sumEvens * sumOdds;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n>0)
            {
                int digit = n % 10;
                if (digit%2!=0)
                {
                    sum += digit;
                }
                n=n/10;
            }
            return sum;
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                n = n / 10;
            }
            return sum;
        }
    }
}
