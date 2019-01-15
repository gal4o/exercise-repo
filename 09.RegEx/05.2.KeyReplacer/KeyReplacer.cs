using System;

namespace _05._2.KeyReplacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();
            string textString = Console.ReadLine();
            string startKey = "";
            for (int i = 0; i < keyString.Length; i++)
            {
                if (keyString[i]== '|' || keyString[i] == '<' || keyString[i] == '\\')
                {
                    break;
                }
                else
                {
                    startKey += keyString[i];
                }
            }
            string endKey = "";
            int lastSearch = keyString.LastIndexOfAny(new char[] { '|', '<', '\\' });
            for (int i = lastSearch+1; i <keyString.Length; i++)
            {
                    endKey += keyString[i];
            }
            string result = "";
            while (textString.Contains(startKey)&&textString.Contains(endKey))
            {
                int start = textString.IndexOf(startKey) + startKey.Length;
                int end = textString.IndexOf(endKey);
                result += textString.Substring(start, end - start);
                textString = textString.Remove(end,1);
                textString = textString.Remove(textString.IndexOf(startKey),1);
            }
            if (result.Length==0)
            {
                Console.WriteLine("Empty result");
            }
            else
            Console.WriteLine(result);
        }
    }
}
