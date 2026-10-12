using System;
using System.Globalization;

namespace ExercicioResolvido03Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            n = int.Parse(Console.ReadLine());
            string[] nome = new string[n];
            int[] idade = new int[n];
            double[] altura = new double[n];

            //Leitura dos Dados
            for (int i = 0; i < n ; i++)
            {
                string[] x = Console.ReadLine().Split(' ');
                nome[i] = x[0];
                idade[i] = int.Parse(x[1]);
                altura[i] = double.Parse(x[2], CultureInfo.InvariantCulture);
            }
            //Calculo da Altura media
            double soma = 0.0;
            for (int i = 0; i < n ; i++)
            {
                soma = soma + altura[i];
            }
            double media = soma / n;
            
            // Percentual de menores de 16 anos

            int cont = 0;

            for (int i = 0; i < n; i++)
            {
                if (idade[i] < 16)
                {
                    cont++;
                }
            }
            double percentual = (double) cont / n * 100;

            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pessoas com menos de 16 anos: " + percentual.ToString("F1", CultureInfo.InvariantCulture) + "%");
        }
    }
}