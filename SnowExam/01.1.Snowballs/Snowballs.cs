using System;
using System.Numerics;
namespace _01._1.Snowballs
{
    class Snowballs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger maxVallue = -1;
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;
            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger vallue = BigInteger.Pow(snow / time, quality);
                if (vallue>maxVallue)
                {
                    maxVallue = vallue;
                    maxSnow = snow;
                    maxTime = time;
                    maxQuality = quality;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxVallue} ({maxQuality})");
        }
    }
}
