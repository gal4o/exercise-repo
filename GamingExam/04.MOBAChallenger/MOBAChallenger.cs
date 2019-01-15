using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MOBAChallenger
{
    class MOBAChallenger
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> players =
                new Dictionary<string, Dictionary<string, int>>();

            while (input!="Season end")
            {
                string[] data = input.Split(' ');
                string player = data[0];
                if (data[1]=="vs")
                {
                    string player2 = data[2];
                    if (players.ContainsKey(player)&&players.ContainsKey(player2))
                    {
                        foreach (var item in players[player])
                        {
                            if (players[player2].ContainsKey(item.Key))
                            {
                                if (players[player2].Values.Sum()>players[player].Values.Sum())
                                {
                                    players.Remove(player);
                                }
                                else if (players[player].Values.Sum() > players[player2].Values.Sum())
                                {
                                    players.Remove(player2);
                                }
                                break;
                            }
                        }
                    }                  
                }
                else
                {
                    string position = data[2];
                    int skill = int.Parse(data[4]);
                    if (players.ContainsKey(player))
                    {
                        if (players[player].ContainsKey(position))
                        {
                            if (players[player][position]<skill)
                            {
                                players[player][position] = skill;
                            }
                        }
                        else
                        {
                            players[player].Add(position, skill);
                        }
                    }
                    else
                    {
                        Dictionary<string, int> info =
                            new Dictionary<string, int>();
                        info.Add(position, skill);
                        players.Add(player, info);
                    }
                }
                input = Console.ReadLine();
            }

            players = players
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value
                   .ToDictionary(y => y.Key, y => y.Value));

            foreach (var player in players)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var skill in player.Value
                    .OrderByDescending(x=>x.Value)
                    .ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"- {skill.Key} <::> {skill.Value}");
                }
            }
        }
    }
}
