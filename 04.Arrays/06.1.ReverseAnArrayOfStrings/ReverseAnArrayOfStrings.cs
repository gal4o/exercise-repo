using System;
using System.Linq;
namespace _06._1.ReverseAnArrayOfStrings
{
    class ReverseAnArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();            
            ReverseArray(input);
        }

        static void ReverseArray(string[] arr)
        {
            string[] revArr = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                revArr[i] = arr[arr.Length - 1 - i];
            }
            Console.WriteLine(string.Join(" ", revArr));
        }
    }
}
