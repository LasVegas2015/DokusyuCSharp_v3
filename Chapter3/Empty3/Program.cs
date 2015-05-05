using System;

namespace Empty3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0;

            for (i = 1; i <= 5; sum += i++) ;
            Console.WriteLine("Sum is " + sum);
        }
    }
}
