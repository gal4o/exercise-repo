using System;
using System.Collections.Generic;

namespace _09._2.TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            SortedDictionary<string,List< string>> clubs =
                new SortedDictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            string[] input;
            for (int i = 0; i < n; i++)
            {
                List<string> members = new List<string>();
                input = Console.ReadLine().Split('-');
                string name = input[0];
                string club = input[1];
                members.Add(name);
                if (clubs.ContainsKey(club))
                {
                    Console.WriteLine("Team {0} was already created!", club);
                }
                else if (clubs.ContainsValue(members))
                {
                    Console.WriteLine("{0} cannot create another team!", name);
                }
                else
                {
                    Console.WriteLine("Team {0} has been created by {1}!",club,name);
                    clubs.Add(club, members );
                }
            }
            input = Console.ReadLine().Split("->");
            while (input[0]!="end of assignment")
            {
                string name = input[0];
                string club = input[1];
                List<string> members = new List<string>();
                members.Add(name);
                if (!clubs.ContainsKey(club))
                {
                    Console.WriteLine("Team {0} does not exist!", club);
                }
                else if(clubs.ContainsValue(members)) //
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", name, club);
                }
                else
                {
                    clubs[club].AddRange(members);
                }
                input = Console.ReadLine().Split("->");
            }
            List<string> disband = new List<string>();

            foreach (var club in clubs)
            {
                if (club.Value.Count>1)
                {
                    Console.WriteLine($"{club.Key}");
                    for (int i = 0; i < club.Value.Count; i++)
                    {
                        if (i==0)
                        {
                            Console.WriteLine($"- {club.Value[i]}");
                        }
                        else
                        {
                            Console.WriteLine($"-- {club.Value[i]}");
                        }
                    }
                }
                else
                {
                    disband.Add(club.Key);
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var club in disband)
            {
                Console.WriteLine(club);
            }
        }
    }
}
