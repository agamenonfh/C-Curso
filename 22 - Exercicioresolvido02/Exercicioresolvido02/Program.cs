using System;
using System.Globalization;

namespace ExercicioResolvido02
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h, area, perimetro, diagonal;
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = b * h;
            perimetro = 2 * (b + h);
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(h, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}