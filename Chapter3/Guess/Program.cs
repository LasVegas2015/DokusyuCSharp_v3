using System;

namespace Guess
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
        }
    }
}
