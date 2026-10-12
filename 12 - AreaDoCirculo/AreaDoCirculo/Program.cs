using System;
using System.Globalization;

namespace AreaDoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {

            double area, π, raio;

            π = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = π * Math.Pow(raio, 2.0);


            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}