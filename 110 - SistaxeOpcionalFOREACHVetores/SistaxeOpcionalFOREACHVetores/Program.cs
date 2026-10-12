using System;
using System.Globalization;

namespace SintaxeOpcionalFOREACHVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos:");
            foreach (string nome in vet)
            {
                Console.WriteLine(nome);
            }
        }
    }
} 