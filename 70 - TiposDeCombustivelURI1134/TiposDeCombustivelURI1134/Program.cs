using System;
using System.Globalization;

namespace TiposDeCombustivelURI1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool, gasolina, diesel, entrada, fim;
            alcool = 0;
            gasolina = 0;
            diesel = 0;
            entrada = 0;

            while (entrada != 4)
            {
                entrada = int.Parse(Console.ReadLine());
                if (entrada == 1)
                {
                    alcool = alcool + 1;
                }
                else if (entrada == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (entrada == 3)
                {
                    diesel = diesel + 1;
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}