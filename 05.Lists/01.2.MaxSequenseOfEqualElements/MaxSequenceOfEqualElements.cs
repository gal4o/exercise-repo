using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._2.MaxSequenseOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ").ToList();
            string equal = "";
            int maxCount = 0;
            int count = 1;

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i]==input[i-1])
                {
                    count++;
                    if (count>maxCount)
                    {
                        maxCount = count;
                        equal = input[i];
                    }
                }
                else
                {
                    count = 1;                   
                        if (count > maxCount)
                        {
                            maxCount = count;
                            equal = input[i-1];
                        }                    
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{equal} ");
            }
        }
    }
}
