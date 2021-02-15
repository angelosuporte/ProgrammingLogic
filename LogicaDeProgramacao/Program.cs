using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Media ponderada = peque as notas * cada peso, e some os dois produtos, depois pegue a soma dos produtos divide pela soma dos pesos
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pesoA = 3.5;
            double pesoB = 7.5;

            double somaNotas = (A * pesoA) + (B * pesoB);
            double media = somaNotas / (pesoA + pesoB);

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

