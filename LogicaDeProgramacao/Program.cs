using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Some mathematical functions in C# Math.Sqrt, Math.Pow, Math.Abs
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A,B,C;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine("Square root of " + x + " = " + A);
            Console.WriteLine("Square root of " + y + " = " + B);
            Console.WriteLine("Square root of 25 = " + C);

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine(x  + " Raised to a " + y + " = " + A);
            Console.WriteLine(x + " Raised squared = " + B);
            Console.WriteLine("5 raised squared = " + C);

            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine("Absolute value of " + y + " = " + A);
            Console.WriteLine("Absolute value of " + z + " = " + B);
            

            Console.ReadKey();
            

        }
    }
}
