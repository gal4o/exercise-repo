using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            uint centuries = uint.Parse(Console.ReadLine());
            uint years = centuries * 100;
            uint days = (uint)(years * 365.2422);
            ulong hours = days * 24ul;
            ulong minutes = 60 * hours;
            Console.WriteLine("{0} canturies = {1} years = {2} days = {3} hours = {4} minutes",
                centuries,years,days,hours,minutes);
        }
    }
}
