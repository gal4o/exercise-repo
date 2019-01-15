using System;
using System.Numerics;

namespace _01.HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double metTrav = (n / 1000.00) * m;
            int secPass = (n / 100) + (n / p) * 5;
            Console.WriteLine("{0:f2} m.", metTrav);
            Console.WriteLine("{0} s.", secPass);
        }
    }
}
