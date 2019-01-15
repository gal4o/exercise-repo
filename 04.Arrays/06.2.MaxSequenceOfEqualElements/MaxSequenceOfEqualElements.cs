using System;
using System.Linq;
namespace _06._2.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            int count = 1;
            int countMax = 0;
            string equal = "" ;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i]==input[i-1])
                {
                    count++;
                    if (count>countMax)
                    {
                        countMax = count;
                        equal = input[i];
                    }
                }
                else
                {
                    count = 1;
                    if (count > countMax)
                    {
                        countMax = count;
                        equal = input[i-1];
                    }
                }
            }
            string[] equals = new string[countMax];
            for (int i = 0; i < equals.Length; i++)
            {
                equals[i] = equal;
            }
            
           Console.WriteLine(string.Join(" ", equals));
        }
    }
}
