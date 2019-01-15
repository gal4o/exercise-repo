using System;

namespace _03._1.PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int j = 1; j <= n; j++)
            {
                PrintTriangles(j);
            }
            for (int k = n-1; k > 0; k--)
            {
                PrintTriangles(k);
            }
        }

        static void PrintTriangles(int m)
        {
            for (int i = 1; i <= m; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
