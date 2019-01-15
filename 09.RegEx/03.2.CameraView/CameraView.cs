using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._2.CameraView
{
    class CameraView
    {
        static void Main(string[] args)
        {
            int[] tokkens = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            string pattern = @"|<";
            List<string> views = new List<string>();
            while (input.Contains(pattern))
            {
                int startIndex = input.IndexOf(pattern);
                string camera = "";
                if (startIndex + 2 + tokkens[0] + tokkens[1] > input.Length )
                {
                     camera = input.Substring(startIndex + 2 + tokkens[0], input.Length - (startIndex + 2 + tokkens[0]));
                }
                else
                {
                     camera = input.Substring(startIndex + 2 + tokkens[0], tokkens[1]);
                }
                if (camera.Contains("|<"))
                {
                    int camInd = camera.IndexOf("|<");
                    camera = camera.Substring(0, camInd);
                }
                else if (camera.EndsWith('|') && input[startIndex + 2 + tokkens[0] + tokkens[1]] == '<')
                {
                    camera = camera.Remove(camera.Length - 1);
                }
                views.Add(camera);
                input = input.Remove(startIndex, 2);
            }
            Console.WriteLine(string.Join(", ",views));
        }
    }
}
