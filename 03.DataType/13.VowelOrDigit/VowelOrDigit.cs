using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();
            try
            {
                int.Parse(symbol);
                Console.WriteLine("digit"); 
            }
            catch (Exception)
            {
                if (symbol=="a"||symbol=="o"||symbol=="u"||symbol=="i"||symbol=="e"||symbol=="y")
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }

            }
        }
    }
}
