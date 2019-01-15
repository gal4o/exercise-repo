using System;
using System.Linq;

namespace _03._2.IntersectionOfCircles
{
    class IntersectionOfCircles
    {
        static void Main(string[] args)
        {
            double[] first = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            double[] second = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            Point firstPoint = new Point(first[0], first[1]);
            Point secondPoint = new Point(second[0], second[1]);
            Circle c1 = new Circle(firstPoint, first[2]);
            Circle c2 = new Circle(secondPoint, second[2]);

            Console.WriteLine(IsIntersect(c1,c2) ? "Yes": "No");
        }

        static bool IsIntersect(Circle c1, Circle c2)
        {
            double d = Math.Sqrt(Math.Pow((c2.Cener.X-c1.Cener.X),2)+Math.Pow((c2.Cener.Y-c1.Cener.Y),2));
            if (d<=c1.Radius+c2.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Circle
    {
        public Point Cener { get; set; }
        public double Radius { get; set; }

        public Circle(Point c, double r)
        {
            this.Cener = c;
            this.Radius = r;
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
