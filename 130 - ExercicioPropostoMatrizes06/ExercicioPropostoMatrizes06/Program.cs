using System;
using System.Globalization;

namespace ExercicioPropostoMatrizes06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[,] a = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            double soma = 0;
            for (int i = 0; i < n; i++)
            {                
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > 0)
                    {
                        soma = (double) soma + a[i, j];
                    }
                }
            }

            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));
            
            int linha = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i == linha)
                {
                    Console.Write("LINHA ESCOLHIDA:");
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(" " + a[i, j].ToString("F1", CultureInfo.InvariantCulture));
                    }
                    Console.WriteLine();
                }
            }
            
            int coluna = int.Parse(Console.ReadLine());

            Console.Write("LINHA ESCOLHIDA:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == coluna)
                    {
                        Console.Write(" " + a[i, j].ToString("F1", CultureInfo.InvariantCulture));
                    }
                }
                
            }
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + a[i, i].ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < 0)
                    {
                        a[i, j] = (double) Math.Pow(a[i, j], 2.0);
                        Console.Write(a[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                    else
                    {
                        Console.Write(a[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}