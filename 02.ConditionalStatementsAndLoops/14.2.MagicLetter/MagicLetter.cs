using System;

namespace _14._2.MagicLetter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char whitout = char.Parse(Console.ReadLine());

            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {
                        if (i!=whitout&&j!=whitout&&k!=whitout)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                        
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
