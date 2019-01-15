using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._2.ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(" ");
            while (command[0]!="Odd")
            {
                if (command[0]=="Even")
                {
                    break;
                }
                else if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    while(input.Contains(element))
                    {                         
                            input.Remove(element);                       
                    }
                }
                else if (command[0]=="Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    input.Insert(position,element);
                }
                command = Console.ReadLine().Split(" ");
            }
            for (int i = 0; i < input.Count; i++)
            {
                if (command[0]=="Odd")
                {
                    if (input[i]%2!=0)
                    {
                        Console.Write($"{input[i]} ");
                    }
                }
                else if (command[0] == "Even")
                {
                    if (input[i]%2==0)
                    {
                        Console.Write($"{input[i]} ");
                    }
                }
            }
        }
    }
}
