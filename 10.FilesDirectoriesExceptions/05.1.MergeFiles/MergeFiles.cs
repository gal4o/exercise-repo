using System;
using System.Collections.Generic;
using System.IO;

namespace _05._1.MergeFiles
{
    class MergeFiles
    {
        static void Main(string[] args)
        {
            string[] first = File.ReadAllLines("FileOne.txt");
            string[] second = File.ReadAllLines("FileTwo.txt");

            List<string> output = new List<string>();
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = i; j < second.Length; j++)
                {
                    output.Add(first[i]);
                    output.Add(second[i]);
                    break;
                }
            }
            File.WriteAllLines("output.txt", output);
        }
    }
}
