using System;

namespace Use_goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, k = 0;

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    for (k = 0; k < 10; k++)
                    {
                        Console.WriteLine("i, j, k: " + i + " " + j + " " + k);
                        if (k == 3) goto stop;
                    }
                }
            }

        stop:
            Console.WriteLine("Stopped! i, j, k: " + i + ", " + j + ", " + k);
        }
    }
}
