using System;
using System.Linq;
namespace _06._3.Heists
{
    class Heists
    {
        static void Main(string[] args)
        {
            string[] prices = Console.ReadLine().Split(" ");
            int priceJewels = int.Parse(prices[0]);
            int priceGold = int.Parse(prices[1]);
            string input = Console.ReadLine();
            int totalEarnings = 0;
            int totalExpenses = 0;

            while (input!="Jail Time")
            {
                string[] inputs = input.Split(" ");
                string loot = inputs[0];
                int heistExpenses = int.Parse(inputs[1]);
                totalExpenses += heistExpenses;
                foreach (var symb in loot)
                {
                    if (symb=='%')
                    {
                        totalEarnings += priceJewels;
                    }
                    else if (symb=='$')
                    {
                        totalEarnings += priceGold;
                    }
                }
                input = Console.ReadLine();
            }
            if (totalEarnings>=totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings-totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(totalEarnings-totalExpenses)}.");
            }
        }
    }
}
