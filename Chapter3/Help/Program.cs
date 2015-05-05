using System;

namespace Help
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;

            Console.WriteLine("Help on:");
            Console.WriteLine("  1. if");
            Console.WriteLine("  2. switch");
            Console.Write("Choose one: ");

            choice = (char)Console.Read();

            switch (choice)
            {
                case '1':
                    Console.WriteLine("The if:\n");
                    Console.WriteLine("if (condition) statement;");
                    Console.WriteLine("else statement;");
                    break;
                case '2':
                    Console.WriteLine("The switch:\n");
                    Console.WriteLine("switch(expression) {");
                    Console.WriteLine("    case constant:");
                    Console.WriteLine("        statement sequence");
                    Console.WriteLine("         break;");
                    Console.WriteLine("    // ...");
                    Console.WriteLine("}");
                    break;
                default:
                    Console.WriteLine("Selection not found");
                    break;
            }
        }
    }
}
