using System;
using System.Collections.Generic;

namespace _01._2.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            while (input[0] != "END")
            {
                string comand = input[0];
                switch (comand)
                {
                    case "A":
                        string number = input[2];
                        string name = input[1];
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
                        name = input[1];
                        if (phonebook.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} -> {phonebook[name]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }
                        break;
                    default:                        
                        foreach (var item in phonebook)
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                        break;
                }
                input = Console.ReadLine().Split(" ");
            }
        }
    }
}

