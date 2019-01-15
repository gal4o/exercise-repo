using System;

namespace _03._2.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall;
            int price = 0;
            if (groupSize<=50)
            {
                hall = "Small Hall";
                price = 2500;
                Console.WriteLine($"We can offer you the {hall}");
            }
            else if (groupSize<=100)
            {
                hall = "Terrace";
                price = 5000;
                Console.WriteLine($"We can offer you the {hall}");

            }
            else if (groupSize<=120)
            {
                hall = "Great Hall";
                price = 7500;
                Console.WriteLine($"We can offer you the {hall}");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            double afterDiscount = 0.00;
            switch (package)
            {
                case "Normal":
                    price += 500;
                    afterDiscount = price - price * 0.05;
                    break;
                case "Gold":
                    price += 750;
                    afterDiscount = price - price * 0.1;
                    break;
                case "Platinum":
                    price += 1000;
                    afterDiscount = price - price * 0.15;
                    break;
            }
            double pricePerPerson = afterDiscount / groupSize;
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
}
