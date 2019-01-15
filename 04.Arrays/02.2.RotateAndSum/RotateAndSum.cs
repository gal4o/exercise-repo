using System;
using System.Linq;
namespace _02._2.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] rotated = new int[input.Length];
            int[] sum = new int[input.Length];
            for (int i = 0; i < k; i++)
            {
                rotated = RotateArr(input);
                input = rotated;
                sum = SumArrays(rotated, sum);
            }
            Console.WriteLine(string.Join(" ",sum));
        }

        static int[] RotateArr(int[] input)
        {
            int[] rotated = new int[input.Length];
            rotated[0] = input[input.Length - 1];
            for (int i = 1; i < input.Length; i++)
            {
                rotated[i] = input[i - 1];
            }
            return rotated;
        }

        static int[] SumArrays (int[] arr1,int[] arr2)
        {
            int[] sumArr = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                sumArr[i] = arr1[i] + arr2[i];
            }
            return sumArr;
        }
    }
}
