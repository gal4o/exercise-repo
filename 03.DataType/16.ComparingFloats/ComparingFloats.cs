using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double input1 = double.Parse(Console.ReadLine());
            double input2 = double.Parse(Console.ReadLine());
            double diff = Math.Abs(input1 - input2);
            if (diff>=0.000001)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
