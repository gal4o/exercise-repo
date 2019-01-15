using System;

namespace _10._1.MultiplicationTable2
{
    class MultiplicationTable2
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int interval = int.Parse(Console.ReadLine());
            if (interval <= 10)
            {
                for (int i = interval; i < 11; i++)
                {
                    Console.WriteLine($"{input} X {i} = {input * i}");
                }
            }
            else
            {
                Console.WriteLine($"{input} X {interval} = {input*interval}");
            }
        }
    }
}
