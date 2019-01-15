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
            while (input != "done")
            {
                string[] order = input.Split(" ");
                string product = order[0];
                long quantOrdered = long.Parse(order[1]);
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == product)
                    {
                        if (i>=quantities.Length||quantities[i]<quantOrdered)
                        {
                            Console.WriteLine($"We do not have enough {product}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{names[i]} x {quantOrdered} costs {quantOrdered * prices[i]:f2}");
                            quantities[i] -= quantOrdered;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
