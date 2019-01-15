using System;

namespace _08._2.CenterPoint
{
    class CenterPoint
    {
        static double x1;
        static double y1;
        static double x2;
        static double y2;

        static void Main(string[] args)
        {
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            double first = GetDistance(x1, y1);
            double second = GetDistance(x2, y2);
            PrintClosest(first, second);
        }

        static double GetDistance(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }

        static void PrintClosest(double first, double second)
        {
            double closest = Math.Min(first, second);
            if (closest==first)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
