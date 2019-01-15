using System;

namespace _09._2.CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            while (true)
            {
                try
                {
                    int integer = int.Parse(input);
                    count++;
                }
                catch (Exception)
                {

                    Console.WriteLine(count);
                    return;
                }
                input = Console.ReadLine();
            }
        }
    }
}
