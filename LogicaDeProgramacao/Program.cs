using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double sales = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = salary + (sales * 0.15);

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

