using System;

namespace _01._1.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 7)
            {
                for (int i = 0; i < day.Length; i++)
                {
                    if (i + 1 == num)
                    {
                        Console.WriteLine(day[i]);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
