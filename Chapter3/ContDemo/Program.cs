using System;


namespace ContDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i <= 100; i++)
            {
                if ((i % 2) != 0) continue;
                Console.WriteLine(i);
            }
        }
    }
}
