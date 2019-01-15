using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string,Dictionary<string,int>> data =
                new Dictionary<string, Dictionary<string,int>>();
            while (input!="Once upon a time")
            {
                string[] inputData = input.Split(' ');
                string name = inputData[0];
                string color = inputData[2];
                int physics = int.Parse(inputData[4]);
                if (data.ContainsKey(color))
                {
                    if (data[color].ContainsKey(name))
                    {
                        data[color][name] = Math.Max(physics, data[color][name]);
                    }
                    else
                    {
                        data[color].Add(name, physics);
                    }
                }
                else
                {
                    Dictionary<string, int> toAdd =
                        new Dictionary<string, int>();
                    toAdd.Add(name, physics);
                    data.Add(color, toAdd);
                }
                input = Console.ReadLine();
            }

            foreach (var color in data
             .OrderByDescending(x=>x.Value.Values.Max())   
           .ThenByDescending(x => x.Value.Keys.Count))
            {
                
                foreach (var dwarf in color.Value)
                {
                    Console.WriteLine($"({color.Key}) {dwarf.Key} <-> {dwarf.Value}");
                }
                
            }
        }
    }
}
