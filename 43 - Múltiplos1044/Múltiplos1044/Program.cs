using System;
using System.Globalization;

namespace Multiplios1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0], CultureInfo.InvariantCulture);
            B = int.Parse(vet[1], CultureInfo.InvariantCulture);
            
            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");

            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}