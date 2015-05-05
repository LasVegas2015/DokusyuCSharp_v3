using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.Write("Enter a letter: ");
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                    Console.WriteLine("Letter is a vowel.");
                    break;
                default:
                    Console.WriteLine("Letter is a consonant.");
                    break;
            }
        }
    }
}
