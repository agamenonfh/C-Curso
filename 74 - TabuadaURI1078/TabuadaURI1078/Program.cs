using System;
using System.Globalization;

namespace TabuadaURI1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, multiplicacao;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                multiplicacao = N * i;
                Console.WriteLine(i + " x " + N + " = " + multiplicacao);
            }
        }
    }
}