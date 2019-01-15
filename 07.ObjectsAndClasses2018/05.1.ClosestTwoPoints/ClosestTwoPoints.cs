using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._1.ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double[] pointLine = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
                Point point = new Point(pointLine[0], pointLine[1]);
                points.Add(point);
            }
            double minDistance = Distance(points[0],points[points.Count-1]);
            List<Point> closestPoints = new List<Point> { points[0], points[points.Count-1] };
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    double distance = Distance(points[i], points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestPoints.Clear();
                        closestPoints = new List<Point> { points[i], points[j] };
                    }
                }
            }
            Console.WriteLine("{0:f3}", minDistance);
            foreach (var point in closestPoints)
            {
                Console.WriteLine("({0}, {1})", point.X,point.Y);
            }
        }
        static double Distance(Point p1, Point p2)
        {
            double d = Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
            return d;
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
