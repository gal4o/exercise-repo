using System;
using System.Linq;
namespace _07._3.InventoryMatcher
{
    class InventoryMatcher
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");
            long[] quantities = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(" ").Select(decimal.Parse).ToArray();
            string input = Console.ReadLine();
            while (input!="done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i]==input)
                    {
                        Console.WriteLine($"{names[i]} costs: {prices[i]}; Available quantity: {quantities[i]}");
                        break;
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
