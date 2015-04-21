using System;

namespace Check_1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch;
            double meter;

            int counter = 0;
            for (inch = 1; inch <= 144; inch++)
            {
                //meter = inch * 39.37;
                meter = inch / 39.37;
                Console.WriteLine(inch + " inches are " + meter + " meters.");

                counter++;
                if (counter == 12)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }
        }
    }
}
