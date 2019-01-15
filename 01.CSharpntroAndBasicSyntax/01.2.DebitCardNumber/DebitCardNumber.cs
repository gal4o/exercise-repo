using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._2.DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());
            int input4 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:d4}", input1,input2, input3,input4);
        }
    }
}
