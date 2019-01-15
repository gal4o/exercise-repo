using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._1.AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|").ToList();
            List<string> output = new List<string>();

            for (int i = input.Count-1; i >= 0; i--)
            {
                List<string> nums = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int j = 0; j < nums.Count; j++)
                {
                    output.Add(nums[j]);
                }
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
