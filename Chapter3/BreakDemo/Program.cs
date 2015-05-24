using System;

namespace BreakDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            num = 100;

            for (int i = 0; i < num; i++)
            {
                if (i * i >= num) break;
                Console.Write(i + " ");
            }
            Console.WriteLine("Loop complete.");
        }
    }
}
