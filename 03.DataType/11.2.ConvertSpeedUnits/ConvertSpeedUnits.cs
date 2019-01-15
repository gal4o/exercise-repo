using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distance = long.Parse(Console.ReadLine());
            float hours = int.Parse(Console.ReadLine());
            float minutes = int.Parse(Console.ReadLine());
            float seconds = int.Parse(Console.ReadLine());
            float allSec = seconds + minutes * 60 + hours * 3600;
            float metForSeconds = distance / allSec;
            float kmForHours = (distance / 1000) / (hours + minutes / 60 + seconds / 3600);
            float milesPerHour = (distance / 1609) / (hours + minutes / 60 + seconds / 3600);
            Console.WriteLine($"{metForSeconds:f6}");
            Console.WriteLine($"{kmForHours:f6}");
            Console.WriteLine($"{milesPerHour:f6}");
        }
    }
}
