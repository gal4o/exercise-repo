using System;
using System.Numerics;
namespace _03._2.EnglishNameOfTheLastDigit
{
    class NameLastDigit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //da ne e int???
            PrintEnglishName(GetLastDigit(input));
        }

        static char GetLastDigit(string input)
        {
            char lastDigit = input[input.Length-1];
            return lastDigit;
        }

        static void PrintEnglishName(char digit)
            {

            switch (digit)
            {
                case '1': Console.WriteLine("one");break;
                case '2': Console.WriteLine("two");break;
                case '3': Console.WriteLine("tree");break;
                case '4': Console.WriteLine("four");break;
                case '5': Console.WriteLine("five"); break;
                case '6': Console.WriteLine("six");break;
                case '7': Console.WriteLine("seven");break;
                case '8': Console.WriteLine("eight");break;
                case '9': Console.WriteLine("nine");break;
                case '0': Console.WriteLine("zero");break;
            }
        }
    }
}
