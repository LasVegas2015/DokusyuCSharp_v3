using System;

namespace Comma
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for (i = 0, j = 10; i < j; i++, j--)
            {
                Console.WriteLine("i and j: " + i + " " + j);
            }
        }
    }
}
