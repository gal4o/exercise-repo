using System;

namespace _06._2.SumBigNumbers
{
    class MultiplyBigNumbers
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string output = "";
            int des = 0;
            for (int i = 0; i < first.Length; i++)
            {
                int outputInt = int.Parse(first[first.Length - 1 - i].ToString())                   
                    * int.Parse(second[0].ToString())
                    +des;
                if (outputInt > 9)
                {
                    int ed = outputInt % 10;
                    des = outputInt / 10;
                    outputInt = ed;
                }
                else
                {
                    des = 0;
                }
                output += outputInt;
            }
            if (des != 0)
            {
                output += des;
            }
            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }
            Console.WriteLine();
        }
    }
}
