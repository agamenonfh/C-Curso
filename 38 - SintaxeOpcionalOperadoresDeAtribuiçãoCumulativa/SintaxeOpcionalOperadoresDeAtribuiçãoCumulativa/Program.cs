using System;
using System.Globalization;

namespace SintaxeOpcionalOperadoresDeAtribuicaoCumilativa
{
    class Program
    {
        static void Main(string[] args)
        {
            double conta;
            int minutos;

            minutos = int.Parse(Console.ReadLine());
            
            conta = 50.00;
            if (minutos > 100)
            {
                conta = conta + (minutos - 100) * 2.00;

            }

            Console.WriteLine("Valor total a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}