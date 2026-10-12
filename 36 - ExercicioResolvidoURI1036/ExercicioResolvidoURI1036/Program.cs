using System;
using System.Globalization;

namespace FormulaDeBhaskara1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, R1, R2, PROVA1, PROVA2, RAIZ, DIVISAO;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            RAIZ = (Math.Pow(B, 2.0) - 4 * A * C);
            DIVISAO = (2 * A);
          
            if ((RAIZ > 0) && (DIVISAO != 0))
            {
             R1 = (-B + Math.Sqrt(RAIZ)) / DIVISAO;
             R2 = (-B - Math.Sqrt(RAIZ)) / DIVISAO;
             Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
             Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
            }
            else
            {
            Console.WriteLine("Impossivel calcular");
            }

        }
    }
}