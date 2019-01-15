using System;

namespace _02._2.ChooseADrink2
{
    class ChooseADrink2
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine("The {0} has to pay {1:f2}.", profession , count*0.70);
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("The {0} has to pay {1:f2}.", profession , count*1.00);
                    break;
                case "SoftUni Student":
                    Console.WriteLine("The {0} has to pay {1:f2}.", profession, count * 1.70);
                    break;
                default:
                    Console.WriteLine("The {0} has to pay {1:f2}.", profession, count * 1.20);
                    break;
            }
        }
    }
}
