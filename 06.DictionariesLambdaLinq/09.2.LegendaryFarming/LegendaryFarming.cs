using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._2.LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            bool haveMatch = false;
            Dictionary<string, int> remainingData =
                new Dictionary<string, int>();
            remainingData.Add("fragments", 0);
            remainingData.Add("shards", 0);
            remainingData.Add("motes", 0);
            SortedDictionary<string, int> junks =
                new SortedDictionary<string, int>();
            while (!haveMatch)
            {
                string material = "";
                int quantity = 0;
                for (int i = 1; i < input.Length; i+=2)
                {
                    material = input[i].ToLower();
                    quantity = int.Parse(input[i - 1]);
                    if (remainingData.ContainsKey(material))
                    {
                        remainingData[material] += quantity;
                        if (remainingData[material] >= 250)
                        {
                            haveMatch = true;
                            goto finaly;
                        }
                    }
                    else
                    {
                        if (junks.ContainsKey(material))
                        {
                            junks[material] += quantity;
                        }
                        else
                        {
                            junks.Add(material, quantity);
                        }
                    }
                }
                finaly:
                foreach (var item in remainingData)
                {
                        if (item.Value >= 250)
                        {
                            string items = "";
                            if (item.Key == "shards")
                            {
                                items = "Shadowmourne";
                            }
                            else if (item.Key == "fragments")
                            {
                                items = "Valanyr";
                            }
                            else
                            {
                                items = "Dragonwrath";
                            }
                            Console.WriteLine($"{items} obtained!");
                            remainingData[item.Key] -= 250;
                            remainingData = remainingData
                                .OrderByDescending(x => x.Value)
                                .ThenBy(x => x.Key)
                                .ToDictionary(x => x.Key, x => x.Value);
                            foreach (var item1 in remainingData)
                            {
                                Console.WriteLine($"{item1.Key}: {item1.Value}");
                            }
                            foreach (var item1 in junks)
                            {
                                Console.WriteLine($"{item1.Key}: {item1.Value}");
                            }
                            return ;
                        }
                }
                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
