using System;

namespace _04._2.Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double priceStudio = 0.00;
            double priceDouble = 0.00;
            double priceSuite = 0.00;
                switch (month)
                {
                    case "May":
                    case "October":
                        priceStudio = 50*nightsCount;
                    priceDouble = 65 * nightsCount;
                    priceSuite = 75 * nightsCount;
                    if (nightsCount>7)
                    {
                        priceStudio -= priceStudio * 0.05;
                    }
                    if (nightsCount > 7 && month == "October")
                    {
                        priceStudio -= (priceStudio/nightsCount);
                    }
                    break;

                    case "June":
                    case "September":
                        priceStudio = 60*nightsCount;
                    priceDouble = 72 * nightsCount;
                    priceSuite = 82 * nightsCount;
                    if (nightsCount>14)
                    {
                        priceDouble -= priceDouble * 0.1;
                    }
                    if (nightsCount>7&&month=="September")
                    {
                        priceStudio -= 60;
                    }
                        break;

                    case "July":
                    case "August":
                    case "December":
                        priceStudio = 68*nightsCount;
                    priceDouble = 77 * nightsCount;
                    priceSuite = 89 * nightsCount;
                    if (nightsCount>14)
                    {
                        priceSuite -= priceSuite * 0.15;
                    }
                        break;
                }
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
            Console.WriteLine($"Double: {priceDouble:f2} lv.");
            Console.WriteLine($"Suite: {priceSuite:f2} lv.");
        }
    }
}
