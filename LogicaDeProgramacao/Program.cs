using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a program that calculates and shows the volume of a sphere and the value of its radius(R) is given.
            //The formula for calculating the volume is: (4 / 3) * pi * R³.Consider(assign) to pi the value 3.14159.
          
            double Pi = 3.14159;
            double R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Volume = (4 / 3.0) * Pi * Math.Pow(R, 3.0);

            Console.WriteLine("VOLUME = " + Volume.ToString("f3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

