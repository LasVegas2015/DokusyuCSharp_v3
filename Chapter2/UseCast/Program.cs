using System;

namespace UseCast
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i + " / 3: " + i / 3);
                Console.WriteLine(i + " / 3 with fractions: {0:#.##}", (double)i / 3);
                Console.WriteLine();
            }
        }
    }
}
