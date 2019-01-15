using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._2.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split(' ');
            while (commands[0]!="end")
            {
                switch (commands[0])
                {
                    case "add":                   
                        int index = int.Parse(commands[1]);
                        int element = int.Parse(commands[2]);
                            input.Insert(index, element);
                        break;
                    case "addMany":
                        int indexForMany = int.Parse(commands[1]);
                        List<int> forInsert = new List<int>();
                        for (int i = 2; i < commands.Length; i++)
                        {
                            forInsert.Add(int.Parse(commands[i]));
                        }
                            input.InsertRange(indexForMany, forInsert);
                        break;
                    case "contains":
                        int containsElement = int.Parse(commands[1]);
                        Console.WriteLine(input.IndexOf(containsElement)); 
                        //if (input.Contains(containsElement))
                        //{
                        //    for (int i = 0; i < input.Count; i++)
                        //    {
                        //        if (input[i]==containsElement)
                        //        {
                        //            Console.WriteLine(i);
                        //            break;
                        //        }
                        //    }
                        //}
                        //else
                        //{
                        //    Console.WriteLine(-1);
                        //}
                        break;
                    case "remove":
                        int indForRemove = int.Parse(commands[1]);
                            input.RemoveAt(indForRemove);                        
                        break;
                    case "shift": //
                        int position = int.Parse(commands[1]);
                        position = position % input.Count;
                        List<int> newInput = new List<int>();
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (i + position < input.Count)
                            {
                                newInput.Add(input[i + position]);
                            }
                            else
                            {
                                newInput.Add(input[i + position - input.Count]);
                            }
                        }
                        input = newInput;
                        break;
                    case "sumPairs": //input[i]+= input[i+1];input.RemAt(inp[i+1])
                        List<int> output = new List<int>();
                        if (input.Count == 1)
                        {
                            output.Add(input[0]);
                        }
                        else
                        {
                            for (int i = 1; i < input.Count; i += 2)
                            {
                                output.Add(input[i - 1] + input[i]);
                                if (i == input.Count - 2)
                                {
                                    output.Add(input[i + 1]);
                                }
                            }
                        }
                        input = output;
                        break;
                    case "print":
                        Console.WriteLine("[{0}]", string.Join(", ", input));
                        return;
                }
                commands = Console.ReadLine().Split(' ');
            }
        }
    }
}
