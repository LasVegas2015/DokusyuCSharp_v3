using System;

namespace RegPay
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Principal;
            decimal IntRate;
            decimal PayPerYear;
            decimal NumYears;
            decimal Payment;
            decimal numer, denom;
            double b, e;

            Principal = 1000000.0m;
            IntRate = 0.075m;
            PayPerYear = 12.0m;
            NumYears = 5.0m;

            numer = IntRate * Principal / PayPerYear;

            e = (double)-(PayPerYear * NumYears);
            b = (double)(IntRate / PayPerYear) + 1;

            denom = 1 - (decimal)Math.Pow(b, e);

            Payment = numer / denom;

            Console.WriteLine("Payment is {0:C} ", Payment);
        }
    }
}
