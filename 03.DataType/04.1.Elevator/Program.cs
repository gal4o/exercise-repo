﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._1.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfpeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)numberOfpeople / capacity);
            Console.WriteLine(courses);
        }
    }
}
