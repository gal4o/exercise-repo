using System;

namespace _05._2.MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            string first = input[0];
            string second = input[1];
           // bool isExchangeable;
            int minLenght = Math.Min(first.Length, second.Length);
            //string trying="";
            
            for (int i = 0; i < minLenght; i++)
            {
                first = first.(first[i], second[i]);
            }
            if (first==second)
            {
                Console.WriteLine("true");
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
            //Console.WriteLine(trying);
        }
       // static bool IsExchangeable(string first,string second)
       // {
            
        //}
    }
}
