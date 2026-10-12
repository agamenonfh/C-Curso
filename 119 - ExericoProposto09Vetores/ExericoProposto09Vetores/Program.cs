using System;
using System.Globalization;

namespace ExercicioProposto09Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nome = new string[n];
            double[] precoDeCompra = new double[n];
            double[] precoDeVenda = new double[n];
            int lucroMenos10=0, lucroMenos20=0, lucroMais20=0;

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                precoDeCompra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                precoDeVenda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }
            double lucro = 0.0, compra = 0.0, venda = 0.0, total = 0.0;
            for (int i = 0; i < n; i++)
            {
                lucro = precoDeVenda[i] - precoDeCompra[i];
                if (lucro < precoDeCompra[i] / 10)
                {
                    lucroMenos10++;
                }
                else if (lucro <= precoDeCompra[i] / 5)
                {
                    lucroMenos20++;
                }
                else
                {
                    lucroMais20++;
                }
                compra = (double) compra + precoDeCompra[i];
                venda = (double) venda + precoDeVenda[i];

            }
            total = venda - compra;
            Console.WriteLine("Lucro abaixo de 10%: " + lucroMenos10);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucroMenos20);
            Console.WriteLine("Lucro acima de 20%: " + lucroMais20);
            Console.WriteLine("Valor total de compra: " + compra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + venda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}