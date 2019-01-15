using System;

namespace _11._2.DifferentNumbers
{
    class DifferentNumbers
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if ((second - first) >= 4)
            {
                for (int i = first; i <= second; i++)
                {
                    for (int j = i + 1; j <= second; j++)
                    {
                        for (int k = j + 1; k <= second; k++)
                        {
                            for (int l = k + 1; l <= second; l++)
                            {
                                for (int m = l + 1; m <= second; m++)
                                {

                                    Console.Write(i + " ");
                                    Console.Write(j + " ");
                                    Console.Write(k + " ");
                                    Console.Write(l + " ");
                                    Console.WriteLine(m + " ");


                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
