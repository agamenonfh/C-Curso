using System;
using System.Globalization;

namespace IdadesURI1154
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, media, soma, somaIdade;
            soma = 0;
            somaIdade = 0;
            idade = double.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                if (idade >= 0)
                {
                    soma = soma + 1;
                    somaIdade = somaIdade + idade;
                }
                idade = double.Parse(Console.ReadLine());
            }
            media = somaIdade / soma;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}