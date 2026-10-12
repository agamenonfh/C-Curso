using System;
using System.Globalization;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, consumo;
            X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//Quantidade de Kilometros totais percorridos
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//Quantidade de litros de combustível consumidos
            consumo = X / Y;//Consumo médio de combustível

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}