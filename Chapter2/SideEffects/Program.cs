using System;

namespace SideEffects
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            i = 0;

            if (false & (++i < 100))
                Console.WriteLine("this won't be displayed");
            Console.WriteLine("if statemsnt executed: " + i);

            if (false && (++i < 100))
                Console.WriteLine("this won't be displayed");
            Console.WriteLine("if statemsnt executed: " + i);
        }
    }
}
