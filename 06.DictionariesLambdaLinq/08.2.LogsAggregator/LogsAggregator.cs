using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._2.LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, int>> data =
                new SortedDictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string ip = input[0];
                string name = input[1];
                int durations = int.Parse(input[2]);
                if (data.ContainsKey(name))
                {
                    if (data[name].ContainsKey(ip))
                    {
                        data[name][ip]+=durations;
                    }
                    else
                    {
                        data[name].Add(ip, durations);
                    }
                }
                else
                {
                    data.Add(name, new SortedDictionary<string, int>());
                    data[name].Add(ip, durations);
                }
            }
            foreach (var user in data)
            {
                Console.Write($"{user.Key}: {user.Value.Values.Sum()} [");
                List<string> ips = new List<string>();
                foreach (var item in user.Value)
                {
                    ips.Add(item.Key);
                }
                Console.Write(string.Join(", ", ips));
                Console.WriteLine(']');
            }
        }
    }
}
