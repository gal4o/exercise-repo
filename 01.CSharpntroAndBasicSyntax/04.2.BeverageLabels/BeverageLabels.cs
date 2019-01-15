using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._2.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            byte sugar = byte.Parse(Console.ReadLine());
            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars",(energy*volume)/100.00, (sugar*volume)/100.00);
        }
    }
}
