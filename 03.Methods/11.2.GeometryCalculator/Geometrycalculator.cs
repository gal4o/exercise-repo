using System;

namespace _11._2.GeometryCalculator
{
    class Geometrycalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", PrintTriangleArea(side,height));
                    break;
                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", PrintSquareArea(sideSquare));
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double heightRec = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", PrintRectArea(width,heightRec));
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:f2}", PrintCircleArea(radius));
                    break;
            }
            
        }

        static decimal PrintTriangleArea(double a, double h)
        {
            decimal area = (decimal)((a * h) / 2);
            return area;
        }

        static decimal PrintSquareArea(double a)
        {
            decimal area = (decimal)Math.Pow(a, 2);
            return area;
        }

        static decimal PrintRectArea(double a, double b)
        {
            decimal area = (decimal)(a * b);
            return area;
        }

        static decimal PrintCircleArea(double r)
        {
            decimal area = (decimal)(Math.PI*r*r);
            return area;
        }
    }
}
