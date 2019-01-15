using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                long inputLong = long.Parse(input);
                Console.WriteLine($"{inputLong} can fit in:");
                if (inputLong>=-128&&inputLong<=127)
                {
                    Console.WriteLine("* sbyte");
                }
                if (inputLong>=0&&inputLong<=255)
                {
                    Console.WriteLine("* byte");
                }
                if (inputLong>= -32768&&inputLong<= 32767)
                {
                    Console.WriteLine("* short");
                }
                if (inputLong>=0&&inputLong<=65535)
                {
                    Console.WriteLine("* ushort");
                }
                if (inputLong>= -2147483648 && inputLong<=2147483647)
                {
                    Console.WriteLine("* int");
                }
                if (inputLong>=0 && inputLong<=4294967295)
                {
                    Console.WriteLine("* uint");
                }
                if (inputLong>=-9223372036854775808 && inputLong<=9223372036854775807)
                {
                    Console.WriteLine("* long");
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine($"{input} can't fit in any type");

            }
        }
    }
}
