using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._1.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                bool special = false;
                int digit = 0;
                int sum = 0;
                int number = i;
                while (number>0)
                {
                    digit = number % 10;
                    sum += digit;
                    number = number / 10;
                }
                if (sum==5||sum==7||sum==11)
                {
                    special = true;
                }
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
