using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.HornetComm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternPriv = @"[0-9]+";
            string patternBroad = @"";
            string format = @"[0-9a-zA-Z]+";
            Dictionary<string, List<string>> data = 
                new Dictionary<string, List<string>>();
            List<string> broad = new List<string>();
            List<string> mess = new List<string>();
            while (input!= "Hornet is Green")
            {
                string[] info = input.Split(" <-> ");
                string firts = info[0];
                string second = info[1];
                Match need = Regex.Match(second,format);
                Match privateMess = Regex.Match(firts,patternPriv);
                Match broadMess = Regex.Match(firts,patternBroad);
                if (need.Length!=0) 
                {
                    if (privateMess.Length!=0)
                    {
                        string recCode = firts;
                        string message = second;
                        recCode = recCode.Reverse().ToString();
                        string outputPr = $"{recCode} -> {message}";
                        mess.Add(outputPr);
                    }
                    else if (broadMess.Length!=0)
                    {
                        string message = firts;
                        string frequency = second;
                        string totfreq = "";
                        for (int i = 0; i < frequency.Length; i++)
                        {
                            if ((frequency[i]>=97)&&(frequency[i]<=122))
                            {
                                totfreq +=(char) (frequency[i] - 32);
                            }
                            else if (frequency[i]>=32&&frequency[i]<=90)
                            {
                                totfreq += (char)(frequency[i] + 32);
                            }
                        }
                        string output = $"{totfreq} -> {message}";
                        broad.Add(output);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            Console.WriteLine(string.Join("\n", broad));
            Console.WriteLine("Messages:");
            Console.WriteLine(string.Join("\n", mess));
        }
    }
}
