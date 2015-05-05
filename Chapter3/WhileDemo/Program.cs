using System;

namespace WhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;

            ch = 'a';
            while (ch <= 'z')
            {
                Console.Write(ch);
                ch++;
            }
        }
    }
}
