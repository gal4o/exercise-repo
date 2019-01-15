using System;
using System.Collections.Generic;

namespace _01._2.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (input[0]!="END")
            {
                string comand = input[0];
                string name = input[1];
                switch (comand)
                {
                    case "A":
                        string number = input[2];
                        if (!phonebook.ContainsKey(name))
                        {
                            phonebook.Add(name, number);
                        }
                        else
                        {
                            phonebook[name] = number;
                        }
                        break;
                    case "S":
                        if (phonebook.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} -> {phonebook[name]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }
                        break;
                }
                input = Console.ReadLine().Split(" ");
            }
        }
    }
}
