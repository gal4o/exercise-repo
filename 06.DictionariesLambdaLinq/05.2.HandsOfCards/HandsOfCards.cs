using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._2.HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<string>> data = 
                new Dictionary<string, List<string>>();
            while (input[0]!="JOKER")
            {
                string name = input[0];
                List<string> cards = input[1].Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();

                if (data.ContainsKey(name))
                {
                    data[name].AddRange(cards);
                }
                else
                {
                    data.Add(name, cards);
                }
                input = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in data)
            {
                Console.Write($"{item.Key}: ");
                List<string> cards = new List<string>();
                for (int i = 0; i < item.Value.Count; i++)
                {
                    if (!cards.Contains(item.Value[i]))
                    {
                        cards.Add(item.Value[i]);
                    }
                }
                int sum = 0;
                foreach (var card in cards)
                {
                    int p = TakeP(card[0]);
                    int t = TakeT(card[card.Length-1]);
                    sum += p * t;                    
                }
                Console.WriteLine($"{sum}");
            }
        }
        static int TakeP(char num)
        {
            string n = num.ToString();
            int p = 0;
            switch (n)
            {
                case "J": p = 11;break;
                case "Q": p = 12;break;
                case "K": p = 13;break;
                case "A": p = 14;break;
                case "2": p = 2; break;
                case "3": p = 3; break;
                case "4": p = 4; break;
                case "5": p = 5; break;
                case "6": p = 6; break;
                case "7": p = 7; break;
                case "8": p = 8; break;
                case "9": p = 9; break;
                case "1": p = 10; break;
            }
            return p;
        }
        static int TakeT(char type)
        {
            int t = 0;
            switch (type)
            {
                case 'S': t = 4; break;
                case 'H': t = 3; break;
                case 'D': t = 2; break;
                case 'C': t = 1; break;
            }
            return t;
        }
    }
}
