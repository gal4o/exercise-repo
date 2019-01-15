using System;
using System.Globalization;

namespace _01._2.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact
                (Console.ReadLine(),"dd-MM-yyyy",CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int count = 0;
            string[] holidaysString = 
                new string[] {"01-01", "03-03", "01-05", "06-05", "24-05", "06-09", "22-09", "01-11", "24-12", "25-12", "26-12" };
            DateTime[] holidays = new DateTime[holidaysString.Length];
            for (int i = 0; i < holidaysString.Length; i++)
            {
                holidays[i] = DateTime.ParseExact(holidaysString[i], "dd-MM", CultureInfo.InvariantCulture);
            }
            
            for (DateTime i = startDate;  i <= endDate; i=i.AddDays(1))
            {             
                if (IsWork(i,holidays))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

         static bool IsWork(DateTime tryDate,DateTime[] holy)
        {

            if (tryDate.DayOfWeek.ToString() == "Saturday" || tryDate.DayOfWeek.ToString() == "Sunday")
            {
                return false;
            }
            else
            {
                foreach (var item in holy)
                {
                    if (tryDate.Date == item.Date) //probl
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
