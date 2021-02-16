using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEmp = int.Parse(Console.ReadLine());
            int workedHours = int.Parse(Console.ReadLine());
            double hourValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = workedHours * hourValue;

            Console.WriteLine("NUMBER = " + numEmp);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

