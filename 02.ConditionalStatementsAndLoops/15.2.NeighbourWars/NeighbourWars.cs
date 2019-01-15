using System;

namespace _15._2.NeighbourWars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());
            int healtPesho = 100;
            int healtGosho = 100;
            int count = 0;
            while (healtGosho>0&&healtPesho>0)
            {
                count++;
                if (count%2==0)
                {
                    healtPesho -= damageGosho;
                    if (healtPesho > 0)
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healtPesho} health.");
                    else
                        break;
                }
                else
                {
                    healtGosho -= damagePesho;
                    if (healtGosho > 0)
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healtGosho} health.");
                    else
                        break;
                }
                if (count%3 == 0)
                {
                    healtGosho += 10;
                    healtPesho += 10;
                }
            }
            if (healtPesho<=0)
            {
                Console.WriteLine($"Gosho won in {count}th round.");
            }
            else
            {
                Console.WriteLine($"Pesho won in {count}th round.");
            }
        }
    }
}
