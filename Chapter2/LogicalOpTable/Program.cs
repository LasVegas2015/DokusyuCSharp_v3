﻿using System;

namespace LogicalOpTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool p, q;

            Console.WriteLine("P\tQ\tAND\tOR\tXOR\tNOT");

            p = true; q = true;
            Console.Write(p + "\t" + q + "\t");
            Console.Write((p & q) + "\t" + (p | q) + "\t");
            Console.WriteLine((p ^ q) + "\t" + (!p));

            p = true; q = false;
            Console.Write(p + "\t" + q + "\t");
            Console.Write((p & q) + "\t" + (p | q) + "\t");
            Console.WriteLine((p ^ q) + "\t" + (!p));

            p = false; q = true;
            Console.Write(p + "\t" + q + "\t");
            Console.Write((p & q) + "\t" + (p | q) + "\t");
            Console.WriteLine((p ^ q) + "\t" + (!p));

            p = false; q = false;
            Console.Write(p + "\t" + q + "\t");
            Console.Write((p & q) + "\t" + (p | q) + "\t");
            Console.WriteLine((p ^ q) + "\t" + (!p));
        }
    }
}
