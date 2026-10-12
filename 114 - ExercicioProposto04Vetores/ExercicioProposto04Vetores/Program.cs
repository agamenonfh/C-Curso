using System;
using System.Globalization;

namespace ExercicioProposto04Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            string[] z = Console.ReadLine().Split(' ');
            double soma = 0, media;

            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(z[i], CultureInfo.InvariantCulture);
                soma = (double) soma + a[i];
            }
            media = (double) soma / n;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));
            for (int i = 0; i < n;i++)
            {
                if (a[i] < media)
                {
                    Console.WriteLine(a[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}