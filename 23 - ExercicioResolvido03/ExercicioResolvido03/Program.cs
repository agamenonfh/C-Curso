using System;
using System.Globalization;

namespace ExercicioResolvido03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1 = Console.ReadLine();
            string nome2 = Console.ReadLine();

            string[] vet1 = nome1.Split(' ');
            string n1 = vet1[0];
            int idade1 = int.Parse(vet1[1]);

            string[] vet2 = nome2.Split(' ');
            string n2 = vet2[0];
            int idade2 = int.Parse(vet2[1]);

            double media = (double)(idade1 + idade2) / 2;

            Console.WriteLine("A idade média de " + n1 + " e " + n2 + " é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos");
        }        
    }
}