using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // data input

            Console.WriteLine(" Good morning, you can start:");
            string phrase = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            Console.WriteLine(phrase);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // with split

            Console.WriteLine("Input three in place of the x, as an example: xxxxx xxxxx xxxxxx ");
            string[] vet = Console.ReadLine().Split(" ");
            string d = vet[0];
            string e = vet[1];
            string f = vet[2];

            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);


            Console.ReadKey();
            

        }
    }
}
