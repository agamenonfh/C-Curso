using System;
using System.Globalization;

namespace ExercicioProposto05Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, soma = 0, cont = 0;
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] z = Console.ReadLine().Split(' ');
            double media;

            for (int i = 0; i < n ; i++)
            {
                a[i] = int.Parse(z[i]);
                if (a[i] % 2 == 0)
                {
                    soma = soma + a[i];
                    cont = cont + 1;
                }
            }
            media = (double)soma / cont;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}