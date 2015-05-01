using System;

namespace UseDecimal
{
    class UseDecimal
    {
        static void Main(string[] args)
        {
            decimal balance;
            decimal rate;

            balance = 1000.10m;
            rate = 0.1m;
            balance = balance * rate + balance;

            Console.WriteLine("New balence: $" + balance);
        }
    }
}
