using System;

namespace _05._2.WordinPlural
{
    class WordInPlural
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();
            if (noun.EndsWith("y"))
            {
                noun=noun.Remove(noun.Length-1);
                Console.WriteLine($"{noun}ies");
            }
            else if (noun.EndsWith("o")||noun.EndsWith("sh")||noun.EndsWith("ch")||noun.EndsWith("s")||noun.EndsWith("x")||noun.EndsWith("z"))
            {
                Console.WriteLine($"{noun}es");
            }
            else
            {
                Console.WriteLine($"{noun}s");
            }           
        }
    }
}
