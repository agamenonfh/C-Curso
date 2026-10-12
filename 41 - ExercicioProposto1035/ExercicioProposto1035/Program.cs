using System;
using System.Globalization;

namespace TesteDeSelecao1_1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0], CultureInfo.InvariantCulture);
            B = int.Parse(vet[1], CultureInfo.InvariantCulture);
            C = int.Parse(vet[2], CultureInfo.InvariantCulture);
            D = int.Parse(vet[3], CultureInfo.InvariantCulture);

            if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");

            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
                
        }
    }
}