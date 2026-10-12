using System;
using System.Globalization;

namespace ExercicioResolvido02Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            int m = int.Parse(a[0]);
            int n = int.Parse(a[1]);

            int[,] s = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] z = Console.ReadLine().Split(' ');
                for ( int j = 0; j < n ; j++ )
                {
                    s[i, j] = int.Parse(z[j]);
                }
            }

            //Soma
            
            for (int i = 0; i < m; i++ )
            {
                int soma = 0;
                for (int j = 0;j < n ; j++ )
                {
                    soma = soma + s[i, j];
                }
                Console.WriteLine(soma);
            }

            //tambem escrito assim
            int[] vet = new int[m];

            for (int i = 0;i < m; i++)
            {
                int soma = 0;
                for (int j = 0; j < n ; j++ )
                {
                    soma = soma + s[i, j];
                }
                vet[i] = soma;
            }

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}