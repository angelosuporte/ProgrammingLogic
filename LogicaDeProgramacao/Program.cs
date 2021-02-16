using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');
            int code = int.Parse(vet[0]);
            int amount = int.Parse(vet[1]);
            double price = double.Parse(vet[2], CultureInfo.InvariantCulture);

            string[] vet1 = Console.ReadLine().Split(' ');
            int code1 = int.Parse(vet1[0]);
            int amount1 = int.Parse(vet1[1]);
            double price1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            double payment = (amount * price) + (amount1 * price1);


            Console.WriteLine("VALOR A PAGAR: R$ " + payment.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

