using System;

namespace _02._1.ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] integers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int newInt = int.Parse(Console.ReadLine());
                integers[i] = newInt;
            }
            ReverseArray(integers);
        }

        static void ReverseArray(int[] arr)
        {
            int[] revArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                revArr[i] = arr[arr.Length-1-i];
            }
            Console.WriteLine(string.Join(" ", revArr));
        }
    }
}
