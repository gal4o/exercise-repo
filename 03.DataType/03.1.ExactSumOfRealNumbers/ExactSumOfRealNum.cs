using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._1.ExactSumOfRealNumbers
{
    class ExactSumOfRealNum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal result = 0M;
            for (int i = 0; i < n; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                result += num;
            }
            Console.WriteLine(result);
        }
    }
}
