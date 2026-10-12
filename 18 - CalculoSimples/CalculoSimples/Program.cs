using System;
using System.Globalization;

namespace CalculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string _1 = Console.ReadLine();
            string _2 = Console.ReadLine();
            string[] vet = _1.Split(' ');
            string[] vet2 = _2.Split(' '); 
            string condigoPeca1 = vet[0];
            int quantidadePeca1 = int.Parse(vet[1]);
            double valorUnitarioPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            string codigoPeca2 = vet2[0];
            int quantidadePeca2 = int.Parse(vet2[1]);
            double valorUnitarioPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);
            double totalAPagar = (quantidadePeca1 * valorUnitarioPeca1) + (quantidadePeca2 * valorUnitarioPeca2);
            Console.WriteLine("VALOR A PAGAR: R$ " + totalAPagar.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}