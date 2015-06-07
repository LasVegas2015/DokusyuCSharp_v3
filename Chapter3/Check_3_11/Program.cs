using System;

namespace Check_3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int  counter = 0;

            for ( ; ; )
            {
                do
                {
                    ch = (char)Console.Read();
                } while (ch == '\n' || ch == '\r');

                if (ch == '.')
                {
                    Console.WriteLine();
                    Console.WriteLine(counter);
                    break;
                }

                if (ch >= 'a' && ch <= 'z')
                {
                    ch -= (char)32;
                    counter++;
                    Console.Write(ch);
                }
                else if (ch >= 'A' && ch <= 'Z')
                {
                    ch += (char)32;
                    counter++;
                    Console.Write(ch);
                }
                else
                {
                    Console.Write(ch);
                }
            }
        }
    }
}
