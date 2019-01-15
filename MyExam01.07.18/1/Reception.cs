using System;

namespace _1
{
    class Reception
    {
        static void Main(string[] args)
        {
            int countSt1 = int.Parse(Console.ReadLine());
            int countSt2 = int.Parse(Console.ReadLine());
            int countSt3 = int.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            int answHour = countSt1 + countSt2 + countSt3;
            int needTime = studentCount / answHour;
            int moreTime = studentCount % answHour;
            if (moreTime != 0)
            {
                needTime = needTime + 1;
            }
            int free = needTime / 3;
            needTime = needTime + free;
            Console.WriteLine($"Time needed: {needTime}h.");
        }
    }
}
