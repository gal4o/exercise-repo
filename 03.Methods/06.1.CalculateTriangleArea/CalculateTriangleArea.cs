using System;

namespace _06._1.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double triangleBase = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}", GetTriangleArea(triangleBase,triangleHeight));
        }

        static double GetTriangleArea(double tBase,double tHeight)
        {
            double area = (tBase*tHeight)/ 2.00;
            return area;
        }
    }
}
