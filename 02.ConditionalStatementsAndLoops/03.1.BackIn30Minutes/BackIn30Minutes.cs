using System;

namespace _03._1.BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int after = minutes + 30;
            if (after>=60)
            {
                after -= 60;
                hours += 1;
            }
            if (hours>=24)
            {
                hours -= 24;
            }
            Console.WriteLine($"{hours}:{after:d2}");
        }
    }
}
