using System;
using System.Globalization;

namespace ExercicioProposto08Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] altura = new double[n];
            char[] sexo = new char[n];
            double maior = 0.0, menor, media, soma = 0.0;
            int cont1 = 0, cont2 = 0;

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(s[1]);
            }

            menor = altura[0];
            maior = altura[0];

            for (int i = 0; i < n; i++)
            {
                if (maior < altura[i])
                {
                    maior = altura[i];
                }
                else if (altura[i] < menor)
                {
                    menor = altura[i];
                }
                else if (sexo[i] == 'M')
                {
                    cont1++;
                }
                else if (sexo[i] == 'F')
                {
                    soma = soma + altura[i];
                    cont2++;                    
                }
            }
            media = soma / cont2;
            Console.WriteLine("Menor altura = " + menor);
            Console.WriteLine("Maior altura = " + maior);
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + cont1);
        }
    }
}