using System;
using System.Collections.Generic;

namespace _05._3.PizzaIngredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            string[] ingragients = Console.ReadLine().Split(" ");
            int searchedLenght = int.Parse(Console.ReadLine());
            List<string> needIngrad = new List<string>();
            int count = 0;
            for (int i = 0; i < ingragients.Length; i++)
            {
                if (ingragients[i].Length==searchedLenght)
                {
                    needIngrad.Add(ingragients[i]);
                    Console.WriteLine($"Adding {ingragients[i]}.");
                    count++;
                    if (count==10)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", needIngrad)}.");
        }
    }
}
