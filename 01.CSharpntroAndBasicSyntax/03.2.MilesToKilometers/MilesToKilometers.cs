using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._2.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", miles*1.60934);
        }
    }
}
