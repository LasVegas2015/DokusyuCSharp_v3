using System;

namespace Mars
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance;
            double lightspeed;
            double delay;
            double delay_in_min;

            distance = 34000000;
            lightspeed = 186000;

            delay = distance / lightspeed;
            //Console.WriteLine("Time delay when talking to Mars: " + delay + " seconds.");
            Console.WriteLine("Time delay when talking to Mars: {0:###.###} seconds.", delay);

            delay_in_min = delay / 60;
            //Console.WriteLine("This is " + delay_in_min + " minutes");
            Console.WriteLine("This is {0:###.###} minutes", delay_in_min);
        }
    }
}
