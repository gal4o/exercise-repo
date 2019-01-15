using System;
using System.Linq;

namespace _04._1.DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            double[] firstLine = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            double[] secondLine = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            Point first = new Point(firstLine[0],firstLine[1]);
            Point second = new Point(secondLine[0], secondLine[1]);
            Console.WriteLine("{0:f3}", Distance(first,second));
        }

        static double Distance(Point p1, Point p2)
        {
            double d = Math.Sqrt(Math.Pow((p2.X-p1.X),2)+Math.Pow((p2.Y-p1.Y),2));
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
