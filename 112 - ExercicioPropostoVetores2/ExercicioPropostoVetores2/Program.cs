using System;
using System.Globalization;

namespace ExercicioPropostoVetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            string[] z = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                x[i] = int.Parse(z[i]);
            }
            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                if (x[i] % 2 == 0)
                {
                    Console.Write(x[i] + " ");
                    soma++;                    
                }
                         
            }
            Console.WriteLine();
            Console.WriteLine(soma);
        }
    }
}