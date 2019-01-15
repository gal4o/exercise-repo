using System;

namespace _01._2.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(" ");
            string[] input2 = Console.ReadLine().Split(" ");
            int countLeft = 0;
            int countRight = 0;
            int countMax = 0;
            for (int i = 0; i < Math.Min(input1.Length,input2.Length); i++)
            {
                if (input1[i]==input2[i])
                {
                    countLeft++;
                    if (countLeft>countMax)
                    {
                        countMax = countLeft;
                    }
                }
                if (input1[input1.Length - 1 - i] == input2[input2.Length - 1 - i])
                {
                    countRight++;
                    if (countRight > countMax)
                    {
                        countMax = countRight;
                    }
                }                
            }
            Console.WriteLine(countMax);
        }
    }
}
