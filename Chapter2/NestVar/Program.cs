using System;

namespace NestVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;

            for (count = 0; count < 10; count++)
            {
                Console.WriteLine("This is count: " + count);

                int count;
                for (count = 0; count < 2; count++)
                {
                    Console.WriteLine("This program is in error!");
                }
            }
        }
    }
}
