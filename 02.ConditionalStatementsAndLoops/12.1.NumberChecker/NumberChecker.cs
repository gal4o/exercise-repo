using System;

namespace _12._1.NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                int.Parse(input);
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");               
            }
        }
    }
}
