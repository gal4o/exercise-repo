using System;
using System.Linq;
namespace _05._2.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] first = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
            char[] second = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
                for (int i = 0; i < Math.Min(first.Length,second.Length); i++)
                {
                    if (first[i]<second[i])
                    {
                        Console.WriteLine(string.Join("", first));
                        Console.WriteLine(string.Join("", second));
                        break;
                    }
                    else if(second[i]<first[i])
                    {
                        Console.WriteLine(string.Join("", second));
                        Console.WriteLine(string.Join("", first));
                        break;
                    }
                else
                {
                    if (first.Length<second.Length)
                    {
                        Console.WriteLine(string.Join("", first));
                        Console.WriteLine(string.Join("", second));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", second));
                        Console.WriteLine(string.Join("", first));
                        break;
                    }
                }
                }
            
        }
    }
}
