using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Alô mundo");
            Console.Write("Ei aluno,  ");

            // Variáveis
            //Entrada de dados 
            string Nome = "estou aprendendo com voçê!";
            int idade = 17;
            double altura = 1.685;

            //Saída de dados
            Console.WriteLine(Nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            //Concatatenação

            Console.WriteLine("Não sei meu nome ainda, mas " + Nome + "Tenho "  + idade + "minutos de idade. " 
                + "Sou seu primeiro programa, mas se fosse uma pessoa, gostaria de crescer "
                + altura.ToString("F2", CultureInfo.InvariantCulture) + " de altura");

            Console.ReadKey();
            

        }
    }
}
