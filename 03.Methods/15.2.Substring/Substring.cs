using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());
        char Search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == Search)
            {
                hasMatch = true;

                int endIndex = jump;

                if (endIndex+i >= text.Length)
                {
                    endIndex = text.Length-i-1;
                }
                string matchedString = text.Substring(i+1, endIndex);
                Console.WriteLine(text[i]+matchedString);
                i += jump;
            }

        }
        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}

