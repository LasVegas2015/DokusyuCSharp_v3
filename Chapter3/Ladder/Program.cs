using System;

namespace Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            for (x = 0; x < 6; x++)
            {
                if (x == 1)
                    Console.WriteLine("x is one");
                else if (x ==2)
                    Console.WriteLine("x is two");
                else if (x == 3)
                    Console.WriteLine("x is one");
                else if (x == 4)
                    Console.WriteLine("x is four");
                else
                    Console.WriteLine("x is not between 1 and 4");
            }
        }
    }
}
