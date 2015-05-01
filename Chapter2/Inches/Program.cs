using System;

namespace Inches
{
    class Inches
    {
        static void Main(string[] args)
        {
            long ci;
            long im;

            im = 5280 * 12;

            ci = im * im * im;

            Console.WriteLine("There are " + ci + " cubic inches in cubic mile.");
        }
    }
}
