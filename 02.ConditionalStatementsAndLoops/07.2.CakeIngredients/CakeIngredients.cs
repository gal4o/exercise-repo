using System;

namespace _07._2.CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            while (input!="Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                count++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
