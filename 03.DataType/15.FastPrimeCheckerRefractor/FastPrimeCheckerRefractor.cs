using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeCheckerRefractor
{
    class FastPrimeCheckerRefractor
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 2; i <= input; i++)
            {
                bool prime = true;
                for (int delio = 2; delio <= Math.Sqrt(i); delio++)
                {
                    if (i % delio == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {prime}");
            }
        }
    }
}
