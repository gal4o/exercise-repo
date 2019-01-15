using System;
using System.Collections.Generic;

namespace _08._2.UseYourChains_Buddy
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> needString = new List<string>();
            while (input.Contains("</p>"))
            {
                int start = input.IndexOf("<p>");
                int end = input.IndexOf("</p>");
                string need = input.Substring(start + 3, end - start-3);
                needString.Add(need);
                input = input.Remove(end,4);
                input = input.Remove(start,3);
            }
            List<string> outputs = new List<string>();
            foreach (var need in needString)
            {
                string output = "";
                for (int i = 0; i < need.Length; i++)
                {
                    if (need[i]>='a'&&need[i]<='m')
                    {
                        output +=(char)( need[i] + 13);
                    }
                    else if (need[i]>='n'&&need[i]<='z')
                    {
                        output += (char)(need[i] - 13);
                    }
                    else if (need[i]>='0' && need[i]<='9')
                    {
                        output +=(char) need[i];
                    }
                    else
                    {
                        if (i!=0 && output[output.Length-1]!=' ')
                        {
                            output += ' ';
                        }
                    }
                }
                outputs.Add(output.Trim(' '));
            }
            foreach (var item in outputs)
            {
                Console.Write(item+' ');
            }
            Console.WriteLine();

        }
    }
}
