﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._2.CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.Write("Health: |");
            Console.Write(new string ('|', currentHealth));
            Console.Write(new string ('.', maxHealth-currentHealth));
            Console.WriteLine('|');
            Console.Write("Energy: |");
            Console.Write(new string ('|', currentEnergy));
            Console.Write(new string('.', maximumEnergy-currentEnergy));
            Console.WriteLine('|');
        }
    }
}
