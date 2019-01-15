using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._2.SrybskoUnleashed
{
    class SrybskoUnleashed
    {
        static bool Have2Longs(string[] input)
        {
            bool have = true;
            try
            {
                long tic = long.Parse(input[input.Length - 2]);
            }
            catch (Exception)
            {
                have = false;
            }
            try
            {
                long price = long.Parse(input[input.Length - 1]);
            }
            catch (Exception)
            {
                have = false;
            }
            return have;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" @");
            Dictionary<string, Dictionary<string, long>> data =
    new Dictionary<string, Dictionary<string, long>>();
            while (input[0] != "End")
            {
                string singer = input[0];
                if (input.Length>1)
                {
                    string[] input2 = input[1].Split(" ");
                    if (Have2Longs(input2))
                    {
                        string venue = "";
                        long totalmoney = 1;
                        for (int i = 0; i < input2.Length; i++)
                        {
                            if (i == input2.Length - 2)
                            {
                                long tickets = long.Parse(input2[i]);
                                totalmoney *= tickets;
                            }
                            else if (i == input2.Length - 1)
                            {
                                long price = long.Parse(input2[i]);
                                totalmoney *= price;
                            }
                            else
                            {
                                venue += input2[i] + " ";
                            }
                        }
                        if (data.ContainsKey(venue))
                        {
                            if (data[venue].ContainsKey(singer))
                            {
                                data[venue][singer] += totalmoney;
                            }
                            else
                            {
                                data[venue].Add(singer, totalmoney);
                            }
                        }
                        else
                        {
                            data.Add(venue, new Dictionary<string, long>());
                            data[venue].Add(singer, totalmoney);
                        }
                    }
                }               
                input = Console.ReadLine().Split(" @");
            }
            data =data.ToDictionary(x=>x.Key
            ,y=>y.Value.OrderByDescending(x =>x.Value)
            .ToDictionary(x => x.Key, x=>x.Value));
            foreach (var city in data)
            {
                Console.WriteLine(city.Key);
                foreach (var name in city.Value)
                {
                    Console.WriteLine($"#  {name.Key} -> {name.Value}");
                }
            }
        }
    }
}
