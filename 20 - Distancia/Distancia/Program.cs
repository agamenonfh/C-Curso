using System;
using System.Globalization;

namespace Distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos, distancia;
            distancia = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);       
            // A diferença entre as velocidades é de 30 km/h, então a diferença de tempo será de 30 minutos por hora ou 1km por 2 minutos.

            minutos = distancia * 2;
            Console.WriteLine(minutos + " minutos");
        }
    }
}