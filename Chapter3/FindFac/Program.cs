﻿using System;

namespace FindFac
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                Console.Write("Factors of " + i + ": ");
                for (int j = 2; j <= i /2; j++)
                {
                    if ((i % j) == 0) Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
