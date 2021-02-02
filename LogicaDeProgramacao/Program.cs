using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // praticte: read one whole number, one letter, one double number. With Split read one name, sex, age and height with the right types

            Console.WriteLine("Hello, you can start:");


            int a = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            double c1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(" ");
            string name = vet[0];
            char sex = char.Parse(vet[1]);
            int age = int.Parse(vet[2]);
            double height = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(name);
            Console.WriteLine(sex);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));



            Console.ReadKey();
            

        }
    }
}
