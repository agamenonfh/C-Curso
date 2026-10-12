using System;
using System.Globalization;

namespace SequenciaDeNumerosESomaURI1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, min, max;
            string[] valores = Console.ReadLine().Split(' ');
            m = int.Parse(valores[0]);
            n = int.Parse(valores[1]);

            while (m > 0 && n > 0)
            {
                int soma = 0;
                if (m < n)
                {
                    min = m;
                    max = n;
                }
                else
                {
                    min = n;
                    max = m;
                }
                for (soma = 0; min <= max; min++)
                {
                    soma = soma + min;
                    Console.Write(min + " ");
                }
                Console.WriteLine("Sum=" + soma);
                valores = Console.ReadLine().Split(' ');
                m = int.Parse(valores[0]);
                n = int.Parse(valores[1]);
            }
        }
    }
}