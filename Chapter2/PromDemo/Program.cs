using System;

namespace PromDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b;
            int i;

            b = 10;
            i = b * b;

            b = 10;
            b = (byte)(b * b);
            //b = b * b;

            Console.WriteLine("i and b: " + i + " " + b);
        }
    }
}
