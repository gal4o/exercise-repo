using System;
using System.Collections.Generic;
using System.Linq;

namespace _4
{
    class ExamResults
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> bann = new List<string>();
            Dictionary<string, Dictionary<string, int>> data =
                new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> langData =
                new Dictionary<string, int>();
            while (input!="exam finished")
            {
                string[] info = input.Split('-');
                string name = info[0];
                if (info[1] == "banned")
                {
                    bann.Add(name);
                }
                else
                {
                    string language = info[1];
                    int points = int.Parse(info[2]);
                    if (langData.Keys.Contains(language))
                    {
                        langData[language] += 1;
                    }
                    else
                    {
                        langData.Add(language, 1);
                    }
                    if (data.ContainsKey(name))
                    {
                        if (data[name].ContainsKey(language))
                        {
                            data[name][language] =
                                Math.Max(data[name][language], points);
                        }
                        else
                        {
                            data[name].Add(language,points);
                        }
                    }
                    else
                    {
                        Dictionary<string, int> result =
                            new Dictionary<string, int>();
                        result.Add(language, points);
                        data.Add(name, result);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var name in data.OrderByDescending(x=>x.Value.Values.Max())
                .ThenBy(x=>x.Key))
            {
                if (!bann.Contains(name.Key))
                {
                    Console.WriteLine($"{name.Key} | {name.Value.Values.Sum()}");
                }
            }
            Console.WriteLine("Submissions:");
            foreach (var language in langData.OrderByDescending
                (x=>x.Value)
                .ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
