using System;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Press S to stop.");

            for (i = 0; (char)Console.Read() != 'S'; i++)
            {
                Console.WriteLine("Pass #" + i);
            }
        }
    }
}
