using System;

namespace _03._2.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (var item in input)
            {
                Console.Write("\\u{0:x4}",Convert.ToUInt16(item));
            }
        }
    }
}
