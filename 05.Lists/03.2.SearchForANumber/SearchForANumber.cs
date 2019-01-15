using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._2.SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> firstRow = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int[] secondRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<int> outputList = new List<int>();
            int numbElementsTake = secondRow[0];
            int numbElementsDelete = secondRow[1];
            int searchNumb = secondRow[2];
            for (int i = 0; i < numbElementsTake; i++)
            {
                outputList.Add(firstRow[i]);
            }
            for (int i = 0; i < numbElementsDelete; i++)
            {
                outputList.RemoveAt(numbElementsDelete-1-i);
            }
            if (outputList.Contains(searchNumb))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
