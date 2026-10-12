using System;
using System.Globalization;

namespace Cedulas1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, cedulasDe100, cedulasDe50, cedulasDe20, cedulasDe10, cedulasDe5, cedulasDe2, cedulasDe1, sobra;
            N = int.Parse(Console.ReadLine());
            cedulasDe100 = N / 100;
            sobra = N % 100;
            cedulasDe50 = sobra / 50;
            cedulasDe20 = sobra % 50 / 20;
            cedulasDe10 = sobra % 50 %20 / 10;
            cedulasDe5 = sobra % 50 %20 % 10 / 5;
            cedulasDe2 = sobra % 50 %20 % 10 % 5 / 2;
            cedulasDe1 = sobra % 50 %20 % 10 % 5 % 2 / 1;

            Console.WriteLine(N);
            Console.WriteLine(cedulasDe100 + " nota(s) de R$ 100,00");
            Console.WriteLine(cedulasDe50 + " nota(s) de R$ 50,00");
            Console.WriteLine(cedulasDe20 + " nota(s) de R$ 20,00");
            Console.WriteLine(cedulasDe10 + " nota(s) de R$ 10,00");
            Console.WriteLine(cedulasDe5 + " nota(s) de R$ 5,00");
            Console.WriteLine(cedulasDe2 + " nota(s) de R$ 2,00");
            Console.WriteLine(cedulasDe1 + " nota(s) de R$ 1,00");

        }
    }
}