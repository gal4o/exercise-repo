using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartASCIITable
{
    class PrintPartAscII
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            for (int i = first; i <= second; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
