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
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pesoA = 2;
            double pesoB = 3;
            double pesoC = 5;

            double somaNotas = (A * pesoA) + (B * pesoB) + (C * pesoC);
            double media = somaNotas / (pesoA + pesoB + pesoC);

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

