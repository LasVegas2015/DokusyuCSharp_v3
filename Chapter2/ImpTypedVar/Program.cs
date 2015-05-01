using System;

namespace ImpTypedVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var pi = 3.1416;
            var radius = 10;

            var msg = "Radius: ";
            var msg2 = "Area: ";

            double area;

            Console.WriteLine(msg2 + radius);
            area = pi * radius * radius;
            Console.WriteLine(msg + area);

            Console.WriteLine();

            radius = radius + 2;

            Console.WriteLine(msg2 + radius);
            area = pi * radius * radius;
            Console.WriteLine(msg + area);

            //radius = 12.2;
        }
    }
}
