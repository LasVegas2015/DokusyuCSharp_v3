using System;

namespace BoolDemo
{
    class BoolDemo
    {
        static void Main(string[] args)
        {
            bool b;

            b = false;
            Console.WriteLine("b is " + b);

            b = true;
            Console.WriteLine("b is " + b);

            if (b)
            {
                Console.WriteLine("This is executed.");
            }

            b = false;
            if (b)
            {
                Console.WriteLine("This is not executed.");
            }

            Console.WriteLine("10 > 9 is " + (10 > 9));
        }
    }
}
