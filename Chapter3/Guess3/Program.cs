using System;

namespace Guess3
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch, answer = 'K';

            Console.WriteLine("I'm thinking of a letter between A and Z.");
            Console.Write("Can you guess it: ");

            ch = (char)Console.Read();

            if (ch == answer) Console.WriteLine("** Right **");
            else
            {
                Console.Write("...Sorry, you're ");

                if (ch < answer) Console.WriteLine("too low");
                else Console.WriteLine("too high");
            }
        }
    }
}
