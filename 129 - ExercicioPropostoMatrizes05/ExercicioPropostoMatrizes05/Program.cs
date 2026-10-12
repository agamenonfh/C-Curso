using System;
using System.Globalization;

namespace ExercicioPropostoMetrizes05
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] s = Console.ReadLine().Split(' ');
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);
            int[,] a = new int[m, n];
            int[,] b = new int[m, n];
            int[,] c = new int[m, n];

            // Matriz A
            for (int i = 0; i < m; i++)
            {
                string[] s1 = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(s1[j]);
                }
            }

            // Matriz B
            for (int i = 0; i < m; i++)
            {
                string[] s1 = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = int.Parse(s1[j]);
                }
            }

            // Matriz C
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int soma = 0;
                    soma = a[i, j] + b[i, j];
                    c[i, j] = soma;
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}