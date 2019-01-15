using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._2.BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool trues = Convert.ToBoolean(input);
            Console.WriteLine(trues?"Yes":"No");
        }
    }
}
