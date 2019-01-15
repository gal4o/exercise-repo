using System;

namespace _06._2.SumBigNumbers
{
    class SumBigNumers
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            int minLenght = Math.Min(first.Length, second.Length);
            string output = "";
            int des = 0;
            for (int i = 0; i < minLenght; i++)
            {
                int outputInt = int.Parse(first[first.Length-1-i].ToString()) 
                    + int.Parse(second[second.Length-1-i].ToString())
                    +des;
                if (outputInt>9)
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
            if (first.Length>second.Length)
            {
                for (int i = 0; i < first.Length-minLenght; i++)
                {
                    int outputInt = int.Parse(first[first.Length - minLenght - 1 - i].ToString())+des;
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
            }
            else if (second.Length > first.Length)
            {
                for (int i = 0; i < second.Length - minLenght; i++)
                {
                    int outputInt = int.Parse(second[second.Length - minLenght - 1 - i].ToString())+des;
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
            }
            if (des!=0)
            {
                output += des;
            }
            for (int i = output.Length-1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }
            
            Console.WriteLine();
        }
    }
}
