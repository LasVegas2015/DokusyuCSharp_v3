using System;

namespace Check_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            char ch;

            do
            {
                ch = (char)Console.Read();
                if (ch == ' ')
                {
                    count++;
                }
            } while (ch != '.');

            Console.WriteLine(count);
        }
    }
}
