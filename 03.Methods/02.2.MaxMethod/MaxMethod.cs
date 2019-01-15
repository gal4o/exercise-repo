using System;

namespace _02._2.MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            Console.WriteLine(GetMax(a,GetMax(b,c)));
        }

        static int GetMax(int a, int b)
        {
            int max = Math.Max(a, b);
            return max;
        }
    }
}
