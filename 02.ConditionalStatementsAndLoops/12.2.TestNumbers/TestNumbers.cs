using System;

namespace _12._2.TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
                for (int i = first; i > 0; i--)
                {
                    for (int j = 1; j <= second; j++)
                    {
                        sum += 3 * i * j;
                        count++;
                        if (sum>=maxSum)
                        {
                            break; 
                        }
                    }
                if (sum>=maxSum)
                {
                    break;
                }
                }
            Console.WriteLine($"{count} combinations");
            if (sum>=maxSum)
            {
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
