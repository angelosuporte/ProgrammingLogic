using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {

            double pi = 3.14159;
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * (n * n);

            Console.WriteLine("A="+area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
