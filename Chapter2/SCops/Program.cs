﻿using System;

namespace SCops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, d;

            n = 10;
            d = 2;
            if (d != 0 && (n % d) == 0)
                Console.WriteLine(d + " is a factor of " + n);

            d = 0;

            if (d != 0 && (n % d) == 0)
                Console.WriteLine(d + " is a factor of " + n);

            if (d != 0 & (n % d) == 0)
                Console.WriteLine(d + " is a factor of " + n);
        }
    }
}
