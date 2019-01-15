using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1.Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string age = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName} {secondName}. You are {age} years old.");
        }
    }
}
