using System;

namespace _04._1.DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopBottom(n);
            PrintMiddle(n);
            PrintTopBottom(n);
        }

        static void PrintTopBottom(int n)
        {
            Console.WriteLine(new string('-',2*n));
        }

        static void PrintMiddle(int n)
        {
            for (int i = 0; i < n-2; i++)
            {
                Console.Write('-');
                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}
