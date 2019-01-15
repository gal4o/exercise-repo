using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._2.UserLogs
{
    class Program
    {
        static void Main(string[] args)//63%...
        {
            string input = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> data =
                new SortedDictionary<string, Dictionary<string, int>>();
            while (input!="end")
            {
                string[] inputData = input.Split(" ");
                string[] ipData = inputData[0].Split("=");
                string[] message = inputData[1].Split("=");
                string[] userData = inputData[2].Split("=");
                string user = userData[1];
                string ip = ipData[1];
                if (data.ContainsKey(user))
                {
                    if (data[user].ContainsKey(ip))
                    {
                        data[user][ip]++;
                    }
                    else
                    {
                        data[user].Add(ip, 1);
                    }
                }
                else
                {
                    data.Add(user, new Dictionary<string, int>());
                    data[user].Add(ip, 1);
                }
                input = Console.ReadLine();
            }
            foreach (var user in data)
            {
                Console.WriteLine($"{user.Key}:");
                int i = 0;
                foreach(var id in user.Value)
                {
                    i++;
                    if (i==user.Value.Count)
                    {
                        Console.WriteLine($"{id.Key} => {id.Value}.");
                    }
                    else
                    {
                        Console.Write($"{id.Key} => {id.Value}, ");
                    }
                }
            }
        }
    }
}
