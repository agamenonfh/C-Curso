using System;
using System.Globalization;

namespace ExercicioPropostoMatrizes01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split(' ');
            int m = int.Parse(s1[0]);
            int n = int.Parse(s1[1]);
            int[,] s = new int[m, n];
            
            //lendo a Matriz
            for (int i = 0; i < m; i++)
            {
                string[] s2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    s[i, j] = int.Parse(s2[j]);
                }
            }

            //excrevendo o resultado
            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (s[i, j] < 0)
                    {
                        Console.WriteLine(s[i, j]);
                    }
                }
            }
        }
    }
}