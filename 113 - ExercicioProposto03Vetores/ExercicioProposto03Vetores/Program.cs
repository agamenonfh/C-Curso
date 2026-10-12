using System;
using System.Globalization;

namespace ExercicioProposto03Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];

            //Linha a
            string[] z = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(z[i]);
            }
            //Linha b
            string[] x = Console.ReadLine().Split(' ');
            for (int i = 0;i < n; i++)
            {
                b[i] = int.Parse(x[i]);
            }
            //Linha c
            for (int i = 0; i < n ; i++)
            {
                c[i] = a[i] + b[i];
            }
            //Impressão
            for (int i = 0; i < n ; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.WriteLine();
        }
    }
}