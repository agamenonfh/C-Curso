using System;
using System.Globalization;

namespace ExercicioPropostoMatrizes03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] s = new int[n, n];
             for (int i = 0; i < n; i++)
             {
                string[] s1 = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    s[i, j] = int.Parse(s1[j]);
                }
             }
                         
            for (int i = 0; i < n; i++)
            {
                int maior = 0;
                for (int j = 0; j < n; j++)
                {
                    if (maior < s[i, j])
                    {
                        maior = s[i, j];
                    }
                }
                Console.WriteLine(maior);
            }
        }
    }
}