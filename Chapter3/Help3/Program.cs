using System;

namespace Help3
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;

            for ( ; ; )
            {
                do
                {
                    Console.WriteLine("Help on:");
                    Console.WriteLine("  1. if");
                    Console.WriteLine("  2. switch");
                    Console.WriteLine("  3. for");
                    Console.WriteLine("  4. while");
                    Console.WriteLine("  5. do-while");
                    Console.WriteLine("  6. break");
                    Console.WriteLine("  7. continue");
                    Console.WriteLine("  8. goto\n");
                    Console.Write("Choose one (q to quit): ");
                    do
                    {
                        choice = (char)Console.Read();
                    } while (choice == '\n' | choice == '\r');
                } while (choice < '1' | choice > '8' & choice != 'q');

                if (choice == 'q') break;

                Console.WriteLine("\n");
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
                    case '3':
                        Console.WriteLine("The for:\n");
                        Console.WriteLine("for (init; condition; iteration)");
                        Console.WriteLine("    statement;");
                        break;
                    case '4':
                        Console.WriteLine("The while:\n");
                        Console.WriteLine("while (condition) statement;");
                        break;
                    case '5':
                        Console.WriteLine("The do-while:\n");
                        Console.WriteLine("do {");
                        Console.WriteLine("    statement;");
                        Console.WriteLine("} while (condition);");
                        break;
                    case '6':
                        Console.WriteLine("The break:\n");
                        Console.WriteLine("break;");
                        break;
                    case '7':
                        Console.WriteLine("The continue:\n");
                        Console.WriteLine("continue;");
                        break;
                    case '8':
                        Console.WriteLine("The goto:\n");
                        Console.WriteLine("goto label;");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
