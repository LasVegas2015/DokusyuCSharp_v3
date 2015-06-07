using System;

namespace Check_3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1000000; i *= 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
