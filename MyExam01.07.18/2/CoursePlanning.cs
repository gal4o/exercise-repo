using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class CoursePlanning
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input!= "course start")
            {
                string[] modify = input.Split(':');
                string command = modify[0];
                switch (command)
                {
                    case "Add":
                        lessons.Add(modify[1]);
                        break;
                    case "Insert":
                        if (!lessons.Contains(modify[1])
                            &&int.Parse(modify[2])<=lessons.Count-1)
                        {
                            lessons.Insert(int.Parse(modify[2]), modify[1]);
                        }
                        else if(!lessons.Contains(modify[1]))
                        {
                            lessons.Add(modify[1]);
                        }
                        break;
                    case "Remove":
                        if (lessons.Contains(modify[1]))  
                        {
                            lessons.Remove(modify[1]);
                            if (lessons.Contains($"{modify[1]}-Exercise"))
                            {
                                lessons.Remove($"{modify[1]}-Exercise");
                            }
                        }          
                        break;
                    case "Swap":
                        int first = lessons.IndexOf(modify[1]);
                        int sec = lessons.IndexOf(modify[2]);
                        if (lessons.Contains(modify[1])&&lessons.Contains(modify[2])) 
                        {
                            string help = lessons[first];
                            lessons[first] = lessons[sec];
                            lessons[sec] = help;
                        }
                        first = lessons.IndexOf(modify[1]);
                        if (lessons.Contains($"{modify[1]}-Exercise"))
                         {
                             lessons.Remove($"{modify[1]}-Exercise");
                             if (first + 1 >= lessons.Count)
                             {
                                 lessons.Add($"{modify[1]}-Exercise");
                             }
                             else
                                 lessons.Insert((first + 1), $"{modify[1]}-Exercise");
                         }
                        sec = lessons.IndexOf(modify[2]);
                        if (lessons.Contains($"{modify[2]}-Exercise"))
                         {
                             lessons.Remove($"{modify[2]}-Exercise");
                             if (sec+1 >= lessons.Count)
                             {
                                 lessons.Add($"{modify[2]}-Exercise");
                             }
                            else
                            {
                                lessons.Insert((sec + 1), $"{modify[2]}-Exercise");
                            }
                         }
                        break;
                    case "Exercise":
                        if (lessons.Contains(modify[1]) 
                            && !lessons.Contains($"{modify[1]}-Exercise"))
                        {
                            if (lessons.IndexOf(modify[1])==lessons.Count-1)
                            {
                                lessons.Add($"{modify[1]}-Exercise");
                            }
                            else
                            lessons.Insert(lessons.IndexOf(modify[1] + 1), $"{modify[1]}-Exercise");
                        }
                        else if (!lessons.Contains(modify[1]))
                        {
                            lessons.Add(modify[1]);
                            lessons.Add($"{modify[1]}-Exercise");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            foreach (var item in lessons)
            {
                Console.WriteLine($"{lessons.IndexOf(item)+1}.{item}");
            }
        }
    }
}
