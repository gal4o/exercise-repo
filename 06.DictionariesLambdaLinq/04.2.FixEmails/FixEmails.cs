using System;
using System.Collections.Generic;

namespace _04._2.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Dictionary<string, string> data = new Dictionary<string, string>();
            while (name!="stop")
            {
                string email = Console.ReadLine();
                string end = email[email.Length-2].ToString()+email[email.Length-1].ToString();
                end = end.ToLower();

                if (end !="us"&& end !="uk")
                {
                    data.Add(name, email);
                }
                name = Console.ReadLine();
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
