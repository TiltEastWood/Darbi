﻿using System;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers1 = new int[10];
            int[] Numbers2 = new int[Numbers1.Length];
            Random rnd = new Random();

            for (int i = 0; i < Numbers1.Length; i++)
            {
                Numbers1[i] = rnd.Next(0, 100);
            }

            Array.Copy(Numbers1, Numbers2, Numbers1.Length);
            Numbers1[Numbers1.Length -1] = -7;

            for (int i = 0; i < Numbers1.Length; i++)
            {
                Console.WriteLine(Numbers1[i]);
            }
        }
    }
}
