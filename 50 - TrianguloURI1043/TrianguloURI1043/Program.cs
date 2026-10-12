using System;
using System.Globalization;

namespace TrianguloURI1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, perimetro, area, menor, meio, maior;
            string[] entrada = Console.ReadLine().Split(' ');
            A = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            B = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            C = double.Parse(entrada[2], CultureInfo.InvariantCulture);

           if (A < B + C && B < A + C && C < A + B)
            {
                perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((A + B) * C) / 2.0;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}