using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, height,area, perimeter, diagonal;

            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * height;
            perimeter = 2 * (b + height);
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(height, 2.0)); //teorema de Pitágoras

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETER = " + perimeter.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

