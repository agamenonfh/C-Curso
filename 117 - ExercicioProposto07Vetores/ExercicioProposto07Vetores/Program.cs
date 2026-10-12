using System;
using System.Globalization;

namespace ExercicioProposto07Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            string[] aluno = new string[n];
            double[] a = new double[n];
            double[] b = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                aluno[i] = s[0];
                a[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                b[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Alunos aprovados:");
            
            //Impressao dos APROVADOS
            
            for (int i = 0; i < n; i++)
            {
                if ((a[i] + b[i]) / 2 >= 6.0)
                {
                    Console.WriteLine(aluno[i]);
                }
            }
        }
    }
}