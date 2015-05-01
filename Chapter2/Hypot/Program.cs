using System;

namespace Hypot
{
    class Hypot
    {
        static void Main(string[] args)
        {
            double x, y, z;

            x = 3;
            y = 4;

            z = Math.Sqrt(x * x + y * y);

            Console.WriteLine("Hypotenuse is " + z);
        }
    }
}
