using System;

namespace Check_2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool p, q;

            Console.WriteLine(@"P       Q       AND     OR      XOR     NOT");

            p = true; q = true;
            DisplayLogicalOpRow(p, q);

            p = true; q = false;
            DisplayLogicalOpRow(p, q);

            p = false; q = true;
            DisplayLogicalOpRow(p, q);

            p = false; q = false;
            DisplayLogicalOpRow(p, q);
        }

        static void DisplayLogicalOpRow(bool p, bool q)
        {
            Console.Write(@"{0,-8}{1,-8}", p, q);
            Console.Write(@"{0,-8}{1,-8}", (p & q), (p | q));
            Console.WriteLine(@"{0,-8}{1,-8}", (p ^ q), (!p));
        }
    }
}
