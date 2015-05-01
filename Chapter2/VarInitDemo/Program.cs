using System;

namespace VarInitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;


            for (x = 0; x < 3; x++)
            {
                int y = -1;
                Console.WriteLine("y is: " + y);
                y = 100;
                Console.WriteLine("y is now: " + y);
            }
        }
    }
}
