using System;

namespace DWDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;

            do
            {
                Console.Write("Press a key following by ENTER: ");
                ch = (char)Console.Read();
            } while (ch != 'q');
        }
    }
}
