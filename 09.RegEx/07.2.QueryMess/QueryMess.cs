using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace _07._2.QueryMess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //string pattern = @"";
            while (input!="END")
            {
                if (input.Contains("+"))
                {
                    input = input.Replace('+', ' ');
                }
                if (input.Contains("%20"))
                {
                    input = input.Replace("%20", " ");
                }
                input = input.Trim(' ');
                string[] series = input.Split("&",StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string,List<string>> pairs = 
                    new Dictionary<string, List<string>>();
                foreach (var query in series)
                {
                    List<string> values = new List<string>();                   
                    int sepIndex = query.IndexOf("=");
                    string field = query.Substring(0, sepIndex);
                    if (query.Contains("?"))
                    {
                        int startIndexField = query.IndexOf("?");
                        field = query.Substring
                            (startIndexField + 1, sepIndex-1 - startIndexField);
                        field = Regex.Replace(field, @"\s+", " ");
                    }
                    string value = query.Substring(sepIndex+1,query.Length-1-sepIndex);
                    value = Regex.Replace(value, @"\s+", " ");
                    values.Add(value);
                    if (pairs.ContainsKey(field))
                    {
                        pairs[field.Trim()].Add(value.Trim());
                    }
                    else
                    {
                        pairs.Add(field.Trim(), values);
                    }
                }
                foreach (var item in pairs)
                {
                    Console.Write("{0}=[{1}]", item.Key,string.Join(", ", item.Value));
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
