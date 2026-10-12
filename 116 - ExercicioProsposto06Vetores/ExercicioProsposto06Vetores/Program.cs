using System;
using System.Globalization;

namespace ExercicioProposto06Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            string[] pessoa = new string[n];
            int[] idade = new int[n];
            int velha = 0;
            string pessoaMaisVelha;

            for (int i = 0; i < n; i++)
            {
                string[] x = Console.ReadLine().Split(' ');
                pessoa[i] = x[0];
                idade[i] = int.Parse(x[1]);
            }

            pessoaMaisVelha = pessoa[0];

            for (int i = 0; i < n; i++)
            {
                if (velha < idade[i])
                {
                    velha = idade[i];
                    pessoaMaisVelha = pessoa[i];
                }                
            }


            Console.WriteLine("Pessoa mais velha: " + pessoaMaisVelha);
        }
    }
}