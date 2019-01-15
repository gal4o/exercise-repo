using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._1.CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double p = Math.PI * r * r;
            Console.WriteLine($"{p:f12}");
        }
    }
}
