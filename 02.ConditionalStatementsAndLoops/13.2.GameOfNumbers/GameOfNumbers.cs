using System;

namespace _13._2.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            string found = " ";
            int count = 0;
            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    count++;
                    if (i+j == magicalNumber)
                    {
                        found = $"{i} + {j} = {i + j}".ToString();
                    }
                }
            }
            if (found == " ")
            {
                Console.WriteLine($"{count} combinations - neither equals {magicalNumber}");
            }
            else
            {
                Console.WriteLine($"Number found! {found}");
            }
        }
    }
}
