using System;

namespace _07._1.MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}", GetMathPower(n,m));

        }

        static double GetMathPower(double n,double m)
        {
            double pow = Math.Pow(n, m);
            return pow;
        }
    }
}
