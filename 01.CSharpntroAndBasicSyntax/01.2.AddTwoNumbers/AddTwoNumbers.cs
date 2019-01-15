using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._2.AddTwoNumbers
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{input1} + {input2} = {input1+input2}");
        }
    }
}
