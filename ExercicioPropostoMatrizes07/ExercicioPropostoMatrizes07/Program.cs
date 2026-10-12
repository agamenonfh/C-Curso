using System;
using System.Globalization;

namespace ExercicioPropostoMatrizes07
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[m, n];

            for (int i = 0;  i < m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int fila = int.Parse(Console.ReadLine());
            fila = fila -1;
            int ultimoDaFila = mat[fila, n - 1];
                       
            for (int j = n - 1; j > 0; j--)
            {
                mat[fila, j] = mat[fila, j - 1];                   
            }
         
            mat[fila, 0] = ultimoDaFila;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}