using System;
using System.Globalization;

namespace ExercicioProposto01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            double[] numeros = new double[n];
            string[] x = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {                
                numeros[i] = double.Parse(x[i], CultureInfo.InvariantCulture);
            }
            double maior = 0;
            int posicao = 0;
            for (int i = 0; i < n; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posicao = i;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}