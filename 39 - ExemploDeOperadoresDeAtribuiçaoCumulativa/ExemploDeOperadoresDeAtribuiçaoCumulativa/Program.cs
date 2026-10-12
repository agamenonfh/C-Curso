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
                conta += (minutos - 100) * 2.00;
                //Essa escrita += substitui a escrita conta = conta + (minutos - 100) * 2.00;
                //da mesma forma que em outras operações, como
                //a += b ~~ a = a + b;
                //a -= b ~~ a - b;
                //a *= b ~~ a * b;
                //a /= b ~~ a / b: 
                //a %= b ~~ a % b.
            }

            Console.WriteLine("Valor total a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}