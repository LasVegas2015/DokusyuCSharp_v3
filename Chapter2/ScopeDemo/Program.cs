using System;

namespace ScopeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = 10;
            if (x == 10)
            {
                int y = 20;

                Console.WriteLine("x and y: " + x + " " + y);
                x = y * 2;
            }
            //y = 100;

            Console.WriteLine("x is " + x);
        }
    }
}
