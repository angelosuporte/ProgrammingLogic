using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {

            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double kmTraveledPerLiter = X / Y;

            Console.WriteLine(kmTraveledPerLiter.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}

