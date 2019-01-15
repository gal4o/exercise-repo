using System;

namespace _09._2.LongerLine
{
    class LongerLine
    {
        static double x1;
        static double y1;
        static double x2;
        static double y2;
        static double x3;
        static double y3;
        static double x4;
        static double y4;
        static double firstPointDistance;
        static double secondPointDistance;
        static double treethPointDistance;
        static double fourthPointdistance;

        static void Main(string[] args)
        {
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            x4 = double.Parse(Console.ReadLine());
            y4 = double.Parse(Console.ReadLine());

            firstPointDistance = GetDistance(x1, y1);
            secondPointDistance = GetDistance(x2, y2);
            treethPointDistance = GetDistance(x3, y3);
            fourthPointdistance = GetDistance(x4, y4);

            double firstLineLenght = GetLineLenght(x1, x2, y1, y2);
            double secondLineLenght = GetLineLenght(x3, x4, y3, y4);

            GetLonger(firstLineLenght, secondLineLenght);
        }

        static double GetLineLenght (double x1, double x2, double y1, double y2)
        {
            double lineLenght = Math.Sqrt(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            return lineLenght;
        }

        static double GetDistance(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }

        static string GetClosestPoint(double first, double second, double xp1, double yp1, double xp2, double yp2)//dobavi za 3,4
        {
            string closestPoint = "";
            
            double closest = Math.Min(first, second);
            if (closest == first)
            {
                closestPoint = $"({xp1}, {yp1})";
            }
            else
            {
                closestPoint = $"({xp2}, {yp2})";
            }
            return closestPoint;
        }
        static string GetFarPoint(double first, double second,double xp1,double yp1,double xp2,double yp2)//dobavi za 3,4
        {

            string farPoint = "";
            double closest = Math.Min(first, second);
            if (closest == first)
            {                
                farPoint = $"({xp2}, {yp2})";
            }
            else
            {                
                farPoint = $"({xp1}, {yp1})";
            }
            return farPoint;
        }

        static void GetLonger(double first, double second)
        {
            double longer = Math.Max(first, second);
            if (longer == first)
            {
                
                Console.WriteLine($"{GetClosestPoint(firstPointDistance, secondPointDistance,x1,y1,x2,y2)}{GetFarPoint(firstPointDistance, secondPointDistance, x1,y1,x2,y2)}");
            }
            else
            {
                Console.WriteLine($"{GetClosestPoint(treethPointDistance, fourthPointdistance,x3,y3,x4,y4)}{GetFarPoint(treethPointDistance, fourthPointdistance, x3,y3,x4,y4)}");
            }
        }
    }
}
