using System;

namespace KbIn
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.Write("Press a key followed by ENTER: ");

            ch = (char)Console.Read();

            Console.WriteLine("Your key is: " + ch);
        }
    }
}
