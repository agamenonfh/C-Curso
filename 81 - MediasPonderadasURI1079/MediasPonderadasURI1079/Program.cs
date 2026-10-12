using System;
using System.Globalization;

namespace MediasPonderadasURI1079
{
    class Program
    {
        static void Main(string[] args)
        {// media poderada: media = (A * 2 + B * 3 + C * 5) / (2 + 3 + 5)
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] nota = Console.ReadLine().Split(' ');
                double nota1 = double.Parse(nota[0], CultureInfo.InvariantCulture);
                double nota2 = double.Parse(nota[1], CultureInfo.InvariantCulture);
                double nota3 = double.Parse(nota[2], CultureInfo.InvariantCulture);

                double media = (nota1 * 2.0 + nota2 * 3.0 + nota3 * 5.0) / (2.0 + 3.0 + 5.0);

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}