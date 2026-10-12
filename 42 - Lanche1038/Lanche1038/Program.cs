using System;
using System.Globalization;

namespace Lache1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            if (codigo == 1)

            {//Cachorro Quente
                Console.WriteLine("Total: R$ " + (quantidade * 4.00).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 2)
            {//X-Salada
                Console.WriteLine("Total: R$ " + (quantidade * 4.50).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 3)
            {//X-Bacon
                Console.WriteLine("Total: R$ " + (quantidade * 5.00).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 4)
            {//Torrada Simples
                Console.WriteLine("Total: R$ " + (quantidade * 2.00).ToString("F2", CultureInfo.InvariantCulture));

            }
            else if (codigo == 5)
            {//Refrigerante
                Console.WriteLine("Total: R$ " + (quantidade * 1.50).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}