using System;

namespace Use_byte
{
    class Use_byte
    {
        static void Main(string[] args)
        {
            byte x;
            int sum;

            sum = 0;
            for (x = 1; x <= 100; x++)
            {
                sum += x;
            }

            Console.WriteLine("Summation of 100 is " + sum);
        }
    }
}
