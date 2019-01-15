using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _07._2.PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, Dictionary<string, long>> data = 
                new Dictionary<string, Dictionary<string, long>>();
            while (input[0]!="report")
            {
                string city = input[0];
                string counry = input[1];
                long population = long.Parse(input[2]);
                if (data.ContainsKey(counry))
                {
                    if (data[counry].ContainsKey(city))
                    {
                        data[counry][city] += population;
                    }
                    else
                    {
                        data[counry].Add(city, population);
                    }
                }
                else
                {
                    data.Add(counry, new Dictionary<string, long>());
                    data[counry].Add(city, population);
                }
                input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            }
            data = data.OrderByDescending(x=>x.Value.Values.Sum())
                .ToDictionary(x=>x.Key,
                x=>x.Value.OrderByDescending(y => y.Value)
                    .ToDictionary(y => y.Key, y => y.Value));
            foreach (var country in data)
            {
                long totPop = country.Value.Values.Sum();
                Console.WriteLine($"{country.Key} (total population: {totPop})");
                foreach (var city in country.Value)
                {               
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
