using System;
using System.Collections.Generic;

namespace _03._2.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> data = new Dictionary<string, int>();
            while (resource!="stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (data.ContainsKey(resource))
                {
                    data[resource] += quantity;
                }
                else
                {
                    data.Add(resource, quantity);
                }
                resource = Console.ReadLine();
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
