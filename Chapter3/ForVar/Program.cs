using System;

namespace ForVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int fact = 1;

            for (int i = 1; i <= 5; i++)
            {
                sum += i;
                fact *= i;
            }

            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Factorial is " + fact);
        }
    }
}
