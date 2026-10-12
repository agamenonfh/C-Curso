using System;
using System.Globalization;

namespace SalarioComBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeDeUmVendedor;
            double salarioFixo, totalEmVendas, comissao, totalDeSalario;

            nomeDeUmVendedor = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalEmVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            comissao = (double)(totalEmVendas * 0.15);
            totalDeSalario = salarioFixo + comissao;

            Console.WriteLine("TOTAL = R$ " + totalDeSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}