using System;
using System.Globalization;

namespace SequenciaS2URI1156
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, soma = 0, den = 1;

            for (num = 1;num <= 39;num += 2)
            {
                soma = soma + num / den;
                den = den * 2.0;
            }
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}