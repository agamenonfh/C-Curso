using System;
using System.Globalization;

namespace ExercicioResolvido01Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {                    
                    a[i, j] = int.Parse(s[j]);                    
                }
            }
            //Seção Diagonal
            Console.WriteLine("DIAGONAL PRINCIPAL :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
            }
            Console.WriteLine();
            // Tambem pode ser ecrito assim: for (int i = 0; i<n; i++) {
            //                                  Console.Write(a[i, i] + " ");
            //                                  }

            //Seção negativos
            int contNegativo = 0;

            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (a[i, j] < 0)
                    {
                        contNegativo++;
                    }
                }
            }
            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + contNegativo);
        }
    }
}