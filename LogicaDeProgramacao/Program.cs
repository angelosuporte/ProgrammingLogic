using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise: Calculating measures and values
            double width, length, squareMeterPrice, area, price;

            width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            length = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            squareMeterPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = width * length;
            price = area * squareMeterPrice;

            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Price = " + price.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadKey();
            

        }
    }
}
