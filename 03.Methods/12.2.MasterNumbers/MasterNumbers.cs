using System;

namespace _12._2.MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (IsSymmetric(i)&&IsSumDiv7(i)&&HaveOneEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsSymmetric(int n)
        {
            string oldNum = n.ToString();
            string revers = "";
            for (int i = oldNum.Length-1; i >= 0; i--)
            {
                revers += oldNum[i];
            }            
            if (oldNum==revers)
            {
                return true;
            }
            return false;
        }

        static bool IsSumDiv7(int n)
        {
            int sumDigit = 0;
            while (n>0)
            {
                sumDigit += n % 10;
                n = n / 10;
            }
            if (sumDigit%7==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool HaveOneEvenDigit(int n)
        {
            int digit = 0;
            while (n>0)
            {
                digit = n % 10;
                n = n / 10;
                if (digit%2==0)
                {
                    return true;
                    break;
                }
            }
            return false;
        }
    }
}
