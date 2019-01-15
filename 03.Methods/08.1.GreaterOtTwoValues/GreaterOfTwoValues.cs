using System;

namespace _08._1.GreaterOtTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    PrintMax(first, second);
                    break;
                case "char":
                    char firstCh = char.Parse(Console.ReadLine());
                    char secondCh = char.Parse(Console.ReadLine());
                    PrintMax(firstCh, secondCh);
                    break;
                case "string":
                    string firstStr = Console.ReadLine();
                    string secondStr = Console.ReadLine();
                    PrintMax(firstStr, secondStr);
                    break;
            }
        }

        static void PrintMax(int first,int second)
        {
            int max = Math.Max(first, second);
            Console.WriteLine(max);
        }

        static void PrintMax(char first,char second)
        {
            char max ;
            if (first>second)
            {
                max = first;
            }
            else
            {
                max = second;
            }
            Console.WriteLine(max);
        }

        static void PrintMax(string first,string second)
        {
            string max = "";
            if (first.CompareTo(second)>=0)
            {
                max = first;
            }
            else
            {
                max = second;
            }
            Console.WriteLine(max);
        }
    }
}
