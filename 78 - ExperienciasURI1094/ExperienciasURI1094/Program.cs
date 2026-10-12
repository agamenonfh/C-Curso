using System;
using System.Globalization;

namespace ExperienciasURI1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ratos = 0, coelhos = 0, sapos = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int quantidade = int.Parse(entrada[0]);
                char tipo = char.Parse(entrada[1]);

                if (tipo == 'C')
                {
                    coelhos = coelhos + quantidade;
                }
                else if (tipo == 'R')
                {
                    ratos = ratos + quantidade;
                }
                else if (tipo == 'S')
                {
                    sapos = sapos + quantidade;
                }
            }
            Console.WriteLine("Total: " + (ratos + coelhos + sapos) + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + ((coelhos * 100.0) / (ratos + coelhos + sapos)).ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + ((ratos * 100.0) / (ratos + coelhos + sapos)).ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + ((sapos * 100.0) / (ratos + coelhos + sapos)).ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}