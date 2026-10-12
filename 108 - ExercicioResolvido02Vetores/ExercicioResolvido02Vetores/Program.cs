using System;
using System.Globalization;

namespace ExercicioResolvido02Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] vet;
            double soma = 0, media;

            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i< n; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                if (i < n-1)
                {
                    Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                else
                {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            
            for (int i = 0; i< n; i++)
            {
                soma = soma + vet[i];
                if (i == n-1)
                {
                    Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
                    media = soma / n;
                    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
                }
            }


        }
    }
}