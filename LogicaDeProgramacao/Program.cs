using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double consumptionFuel = 12.0;
            int travelHours = int.Parse(Console.ReadLine());
            int velocity = int.Parse(Console.ReadLine());

            int distance = travelHours * velocity;
            double amountOfLiters = distance / consumptionFuel;
            Console.WriteLine(amountOfLiters.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

