using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._1.RefractorSpecialNumbers
{
    class RefractorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            bool special = false;

            for (int i = 1; i <= n; i++)
            {
                digit = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{digit} -> {special}");
                sum = 0;
                i = digit;
            }
        }
    }
}
