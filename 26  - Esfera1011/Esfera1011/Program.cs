using System;
using System.Globalization;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double volumeDeUmaEsfera, raio, pi;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pi = 3.14159;
            volumeDeUmaEsfera = (double)((4.0 / 3.0) * pi * Math.Pow(raio, 3));

            Console.WriteLine("VOLUME = " + volumeDeUmaEsfera.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}