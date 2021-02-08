using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // pratice

            Console.Write("What is your composite name: ");
            string name = Console.ReadLine();
            Console.Write("How many rooms do you have in your house: ");
            int room = int.Parse(Console.ReadLine());
            Console.Write("Enter a price for a product: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter with last name, age e height:");
            string[] vet = Console.ReadLine().ToString().Split(" ");
            string lastName = vet[0];
            int Age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(room);
            Console.Write("$");
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(Age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));



            Console.ReadKey();
            

        }
    }
}
