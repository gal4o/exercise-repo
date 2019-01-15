using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._3.ManipulateArray
{
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ");
                switch (command[0])
                {
                    case "Reverse":
                        input = Reverse(input);
                        break;
                    case "Distinct":
                       input = Distinct(input);
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        string repl = command[2];
                        input = Replace(input, index, repl);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }

        static string[] Reverse(string[] input)
        {
            string[] output = new string[input.Length];
            for (int i = 0; i < input.Length ; i++)
            {
                output[i] = input[input.Length - 1 - i];
            }
            return output;
        }

        static string[] Distinct (string[] input)
        {
            List<string> outputList = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!outputList.Contains(input[i]))
                {
                    outputList.Add(input[i]);
                }
            }
            string[] output = new string[outputList.Count];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = outputList[i];
            }
            return output;
        }

        static string[] Replace(string[] input,int index, string replStr)
        {
            input[index] = replStr;
            return input;           
        }
    }
}
