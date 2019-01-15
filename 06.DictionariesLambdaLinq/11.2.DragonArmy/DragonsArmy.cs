using System;
using System.Collections.Generic;

namespace _11._2.DragonArmy
{
    class DragonsArmy
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, List<long>>> data = 
                new Dictionary<string, SortedDictionary<string, List<long>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string type = input[0];
                string name = input[1];
                string damageSt = input[2];
                string healthSt = input[3];
                string armorSt = input[4];
                long damage = 45;
                long health = 250;
                long armor = 10;
                try
                {
                    damage = long.Parse(damageSt);
                }
                catch (Exception)
                {
                    //continue;
                }
                try
                {
                    health = long.Parse(healthSt);
                }
                catch (Exception)
                {
                    //continue;
                }
                try
                {
                    armor = long.Parse(armorSt);
                }
                catch (Exception)
                {
                    //continue;
                }
                List<long> stats = new List<long>();
                stats.Add(damage);
                stats.Add(health);
                stats.Add(armor);
                SortedDictionary<string, List<long>> dragons =
                    new SortedDictionary<string, List<long>>();
                dragons.Add(name, stats);
                if (data.ContainsKey(type))
                {
                    if (data[type].ContainsKey(name))
                    {
                        data[type][name] = stats;
                    }
                    else
                    data[type].Add(name, stats);
                }
                else
                {
                    data.Add(type, dragons);
                }
            }
            foreach (var type in data)
            {
                long damSum = 0;
                long healSum = 0;
                long armSum = 0;
                foreach (var drag in type.Value)
                {
                    damSum += drag.Value[0];
                    healSum += drag.Value[1];
                    armSum += drag.Value[2];
                }
                double damAvg = damSum / ((double)type.Value.Keys.Count);
                double healAvg = healSum / ((double)type.Value.Keys.Count);
                double armAvg = armSum / ((double)type.Value.Keys.Count);

                Console.WriteLine($"{type.Key}::({damAvg:f2}/{healAvg:f2}/{armAvg:f2})");
                foreach (var drag in type.Value)
                {
                    Console.WriteLine($"-{drag.Key} -> damage: {drag.Value[0]}, health: {drag.Value[1]}, armor: {drag.Value[2]}");
                }
            }
        }
    }
}
