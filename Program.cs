﻿using System;
using System.Linq;

namespace ProgLang
{
    class Program
    {
        static void Main()
        {
            double[] h = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();//1
            double v = double.Parse(Console.ReadLine());//2

            Array.Sort(h);//3
            for (int i = 0; i < h.Length; i++)//4
            {
                int g = (int)h[i];//5
                if (g % 2 == 0)//6
                {
                    Console.Write(h[i] + " ");//7
                }
            }
            Console.WriteLine();//8
            for (int i = 0; i < h.Length; i++)//9
            {
                int k = (int)h[i];//5
                if (k % 2 != 0 && h[i] > v)//10
                {
                    Console.Write(h[i] + " ");//11
                }
            }
        }
    }
}
