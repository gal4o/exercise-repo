using System;

namespace _10._2.CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string search = Console.ReadLine();
            switch (search)
            {
                case "face":
                    Console.WriteLine("{0:f2}",GetFace(a) );
                    break;
                case "space":
                    Console.WriteLine("{0:f2}",GetSpace(a) );
                    break;
                case "volume":
                    Console.WriteLine("{0:f2}",GetVolume(a) );
                    break;
                case "area":
                    Console.WriteLine("{0:f2}", GetArea(a));
                    break;
            }
        }

        static decimal GetFace(double a)
        {
            decimal face = (decimal)Math.Sqrt(2*Math.Pow(a,2));
            return face;
        }

        static decimal GetSpace(double a)
        {
            decimal space =(decimal)Math.Sqrt(3*Math.Pow(a,2));
            return space;
        }

        static decimal GetVolume(double a)
        {
            decimal volume =(decimal)Math.Pow(a,3);
            return volume;
        }

        static decimal GetArea(double a)
        {
            decimal area =(decimal)(6*Math.Pow(a,2));
            return area;
        }
    }
}
