using System;
using System.Globalization;

namespace ValidacaoDeNotaURI1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media, soma;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            while (nota1 < 0.00 || nota1 > 10.00)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            

            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota2 < 0.00 || nota2 > 10.00)
            {
                Console.WriteLine("nota invalida");             
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            soma = nota1 + nota2;
            media = soma / 2.0;

            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}