using System;

namespace SqrRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, sroot, rerr;

            for (num = 1.0; num < 100.0; num++)
            {
                sroot = Math.Sqrt(num);
                Console.WriteLine("Square root of " + num + " is " + sroot);

                rerr = num - (sroot * sroot);
                Console.WriteLine("Rounding error is " + rerr);
                Console.WriteLine();
            }
        }
    }
}
