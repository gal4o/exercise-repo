using System;

namespace _01._2.HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", PrintName(input));
            
        }

        static string PrintName(string input)
        {
            return input;
        }
    }
}
