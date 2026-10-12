using System;
using System.Globalization;

namespace TiposDeTriangulosURI1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, menor, meio, maior;
            string[] n = Console.ReadLine().Split(' ');
            a = double.Parse(n[0], CultureInfo.InvariantCulture);
            b = double.Parse(n[1], CultureInfo.InvariantCulture);
            c = double.Parse(n[2], CultureInfo.InvariantCulture);

            if (a < b && a < c)
            {
                menor = a;
                if (b < c)
                {
                    meio = b;
                    maior = c;
                }
                else
                {
                    meio = c;
                    maior = b;
                }
            }
            else if (b < c)
            {
                menor = b;
                if (a < c)
                {
                    meio = a;
                    maior = c;
                }
                else
                {
                    meio = c;
                    maior = a;
                }
            }
            else
            {
                menor = c;
                if (a < b)
                {
                    meio = a;
                    maior = b;
                }
                else
                {
                    meio = b;
                    maior = a;
                }
            }
            
            if (maior >= menor + meio)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }

            else if (Math.Pow(maior, 2.0) == Math.Pow(meio, 2.0) + Math.Pow(menor, 2.0))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
                if (maior == meio && meio == menor)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (maior == meio || meio == menor)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                else
                {

                }
            }
            else if (Math.Pow(maior, 2.0) > Math.Pow(meio, 2.0) + Math.Pow(menor, 2.0))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
                if (maior == meio && meio == menor)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (maior == meio || meio == menor)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                else
                {

                }
            }
            else if (Math.Pow(maior, 2.0) < Math.Pow(meio, 2.0) + Math.Pow(menor, 2.0))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
                if (maior == meio && meio == menor)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (maior == meio || meio == menor)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                else
                {

                }
            }                   
                 
            else
            {

            }

        }
    }
}