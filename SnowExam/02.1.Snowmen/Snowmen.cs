using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._1.Snowmen
{
    class Snowmen
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();
            while (sequence.Count!=1)
            {
                List<int> loosers = new List<int>();
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (loosers.Contains(i))
                    {
                        continue;
                    }
                    else
                    {
                        int attakerIndex = i;
                        int targetIndex = 0;
                        if (sequence[i] >= sequence.Count)
                        {
                            targetIndex = sequence[i] % sequence.Count;
                        }
                        else
                        {
                            targetIndex = sequence[i];
                        }
                        int difference = Math.Abs
                            (attakerIndex - targetIndex);
                        if (attakerIndex == targetIndex)
                        {
                            if (!loosers.Contains(attakerIndex))
                            {
                                loosers.Add(attakerIndex);
                            }
                            Console.WriteLine($"{attakerIndex} performed harakiri");           
                            if (loosers.Count==sequence.Count-1)
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (difference % 2 == 0)
                            {
                                if (!loosers.Contains(targetIndex))
                                {
                                    loosers.Add(targetIndex);
                                }
                                Console.WriteLine($"{attakerIndex} x {targetIndex} -> {attakerIndex} wins");
                                if (loosers.Count == sequence.Count - 1)
                                {
                                    return;
                                }
                            }
                            else if (difference % 2 != 0)
                            {
                                if (!loosers.Contains(attakerIndex))
                                {
                                    loosers.Add(attakerIndex);
                                }
                                Console.WriteLine($"{attakerIndex} x {targetIndex} -> {targetIndex} wins");
                                if (loosers.Count == sequence.Count - 1)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
                loosers = loosers.OrderByDescending(x => x).ToList();
                for (int i = 0; i < loosers.Count; i++)
                {
                    sequence.RemoveAt(loosers[i]);
                }
            }
        }
    }
}
