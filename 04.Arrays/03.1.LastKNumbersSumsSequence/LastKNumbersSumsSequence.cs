using System;

namespace _03._1.LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main(string[] args)

        {
            long n = long.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] arr = new long[n];
            arr[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long newInt = 0;                
                for (int j = i - k; j < i; j++)
                {
                    if (j >= 0)
                    {
                            newInt += arr[j];
                    }
                    else
                    {
                        newInt += 0;
                    }
                }                               
                arr[i] = newInt;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
