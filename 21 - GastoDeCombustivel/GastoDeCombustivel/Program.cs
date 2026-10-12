using System;
using System.Globalization;
    namespace GastoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int km, horas, velocidadeMedia, distanciaPercorrida;
            double gastoDeCombustivel;

            horas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            velocidadeMedia = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            distanciaPercorrida = horas * velocidadeMedia;
            gastoDeCombustivel = distanciaPercorrida / 12.0;

            Console.WriteLine(gastoDeCombustivel.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}