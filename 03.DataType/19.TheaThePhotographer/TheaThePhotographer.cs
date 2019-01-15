using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            ulong numbPic = ulong.Parse(Console.ReadLine());
            ulong filtTime = ulong.Parse(Console.ReadLine());
            ulong filtFaktor = ulong.Parse(Console.ReadLine());
            ulong uplTime = ulong.Parse(Console.ReadLine());
            ulong filtred =(ulong) Math.Ceiling((numbPic * filtFaktor) / 100.0);
            ulong totaltime = filtred * uplTime + numbPic * filtTime;
            ulong sec = totaltime % 60;
            totaltime = totaltime / 60;
            ulong min = totaltime % 60;
            totaltime = totaltime / 60;
            ulong hours = totaltime % 24;
            ulong days = totaltime / 24;
            Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", days, hours,min , sec);
        }
    }
}
