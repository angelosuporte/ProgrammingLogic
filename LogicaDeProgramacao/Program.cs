using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data processing
            // Assignment command. Syntax: <variable> = <expression>

            // Examples below

            Console.WriteLine("Example 1");
            int a, b;

            a = 3;
            b = 2 * a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("Example 2");
            int c = 3;
            double d = 2.0 * c;
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine("Example 3");
            // calculate trapezoid where C = 12, D = 16, e = 10
            double C, D, e, area;

            C = 12.0;                               
            D = 16.0;                                
            e = 10.0;                               
            area = (C + D) / 2.0 * e;
            Console.WriteLine(area);

            Console.WriteLine("Example 4");
            //Example of casting
            int E, f;
            double total;

            E = 3;
            f = 2;

            total = E / f;
            Console.WriteLine(total);

            Console.WriteLine("Calculate same example with casting");
            // with casting
            int g, F;
            double result;

            E = 3;
            f = 2;

            result = (double) E / f;
            Console.WriteLine(result);




            Console.ReadKey();
            

        }
    }
}
