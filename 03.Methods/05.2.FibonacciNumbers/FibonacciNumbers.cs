using System;

namespace _05._2.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFib(n);
        }

        static void PrintFib(int n)
        {
            int fibonacci0 = 1;
            int fibonacci1 = 1;
            if (n == 0)
            {
                Console.WriteLine("1");
            }
            else if (n == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    int fibonacci = fibonacci0 + fibonacci1;
                    if (i == n)
                    {
                        Console.WriteLine(fibonacci);
                    }
                    else
                    {
                        fibonacci0 = fibonacci1;
                        fibonacci1 = fibonacci;
                    }
                }
            }
        }
    }
}
