using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TseamAccount
{
    class TseamAccount
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine().Split(' ').ToList();
            string input = Console.ReadLine();
            while (input!="Play!")
            {
                string[] commands = input.Split(' ');
                string command = commands[0];
                string game = commands[1];
                switch (command)
                {
                    case "Install":
                        if (!games.Contains(game))
                        {
                            games.Add(game);
                        }
                        break;
                    case "Uninstall":
                        if (games.Contains(game))
                        {
                            games.Remove(game);
                        }
                        break;
                    case "Update":
                        if (games.Contains(game))
                        {
                            games.Remove(game);
                            games.Add(game);
                        }
                        break;
                    case "Expansion":
                        string[] gameMod = game.Split('-');
                        string gameBase = gameMod[0];
                        string gameExpans = gameMod[1];
                        string expansedGame = $"{gameBase}:{gameExpans}";
                        if (games.Contains(gameBase))
                        {
                            int indexForInsert = games.IndexOf(gameBase);
                            games.Insert(indexForInsert + 1, expansedGame);
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', games));
        }
    }
}
