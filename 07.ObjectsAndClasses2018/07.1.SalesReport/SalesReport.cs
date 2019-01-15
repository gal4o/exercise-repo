using System;
using System.Collections.Generic;

namespace _07._1.SalesReport
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, double> output =
                new SortedDictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                Sale sale = new Sale()
                {
                    Town = line[0],
                    Product = line[1],
                    Price = double.Parse(line[2]),
                    Quantity = double.Parse(line[3])
                };
                if (output.ContainsKey(sale.Town))
                {
                    output[sale.Town] += sale.TotalSales;
                }
                else
                output.Add(sale.Town, sale.TotalSales);
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public double TotalSales { get { return Price * Quantity; } }

    }
}
