using System;

namespace _02._1.PassedOrFailed
{
    class PassdOrFailed
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            if (input>2.99)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
