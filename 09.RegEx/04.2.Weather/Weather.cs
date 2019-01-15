using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace _04._2.Weather
{
    class Weather
    {
        static void Main(string[] args)
        {
            Dictionary<string,City> citys = new Dictionary<string, City>();
            string input = Console.ReadLine();
            //kuca pat. ne darvi na 3 grupa...
            string pattern = @"(?<city>[A-Z]{2})(?<temperature>[0-9]+.[0-9]{1,2})(?<type>[a-zA-Z]*)(?=\|)";
            Regex regex = new Regex(pattern);
            while (input!="end")
            {
                if (regex.IsMatch(input))
                {
                    Match match = Regex.Match(input, pattern);
                    string city = match.Groups[1].ToString();
                    double temperature = double.Parse(match.Groups[2].ToString());
                    string type = match.Groups[3].ToString();
                    City samCity = new City { Name = city, Temperature = temperature, Type = type };
                    if (citys.ContainsKey(city))
                    {
                        citys[city] = samCity;
                    }
                    else
                    {
                        citys.Add(city,samCity);
                    }
                }
                input = Console.ReadLine();
            }
            citys = citys.OrderBy(x => x.Value.Temperature).ToDictionary(x => x.Key, x => x.Value);
            foreach (var city in citys)
            {
                Console.WriteLine($"{city.Key} => {city.Value.Temperature:f2} => {city.Value.Type}");
            }
        }
        class City
        {
            public string Name { get; set; }
            public double  Temperature { get; set; }
            public string Type { get; set; }
        }
    }
}
