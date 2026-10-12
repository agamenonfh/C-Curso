using System;
using System.Globalization;

namespace MaiorEPosicaoURI1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, posicao = 1;

            for (int i = 1; i <= 100; i++)
            {
                int entrada = int.Parse(Console.ReadLine());
                if (entrada > maior)
                {
                    maior = entrada;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}