using System;
using System.Globalization;

namespace Esfera1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string dados = Console.ReadLine();
            string[] vet = dados.Split(' ');
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //Cálculos de áreas de figuras gerométricas 
            double triangulo, circulo, trapezio, quadrado, retangulo;
            triangulo = (double)(A * C) / 2;
            circulo = (double)3.14159 * Math.Pow(C, 2.0);
            trapezio = (double)(A + B) * C / 2;
            quadrado = (double)Math.Pow(B, 2.0);
            retangulo = (double)A * B;

            //Saída de dados
            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}