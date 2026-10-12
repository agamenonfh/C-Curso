using System;
using System.Globalization;

namespace UltrapassandoZURI1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, z, soma, cont;

            x = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            while (z <= x)
            {
                z = int.Parse(Console.ReadLine());
            }
            soma = x;
            cont = 1;

            do
            {
                x = x + 1;
                soma = soma + x;
                cont = cont + 1;
            } while (cont <= z);

            Console.WriteLine(cont);

        }
    }
}