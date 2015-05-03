﻿using System;

namespace RelLogOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            bool b1, b2;

            i = 10;
            j = 11;
            if (i < j) Console.WriteLine("i < j");
            if (i <= j) Console.WriteLine("i <= j");
            if (i != j) Console.WriteLine("i != j");
            if (i == j) Console.WriteLine("this won't execute");
            if (i >= j) Console.WriteLine("this won't execute");
            if (i > j) Console.WriteLine("this won't execute");

            b1 = true;
            b2 = false;
            if (b1 & b2) Console.WriteLine("this won't execute");
            if (!(b1 & b2)) Console.WriteLine("!(b1 & b2) is true");
            if (b1 | b2) Console.WriteLine("b1 | b2 is true");
            if (b1 ^ b2) Console.WriteLine("b1 ^ b2 is ture");
        }
    }
}
