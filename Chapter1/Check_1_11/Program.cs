using System;

namespace Check_1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 67.5;
            double weightOnMoon = GetWeightOnMoon(weight);

            Console.WriteLine("Weight on the Moon: " + weightOnMoon);
        }

        private static double GetWeightOnMoon(double weight)
        {
            //return weight * 0.83;
            return weight * 0.17;
        }
    }
}
