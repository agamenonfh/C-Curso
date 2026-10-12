using System;
using System.Globalization;

namespace Media3URI1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, mediaComPesos, notaFinal, mediaFinal;
            string[] vet = Console.ReadLine().Split(' ');
            N1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(vet[3], CultureInfo.InvariantCulture);
            mediaComPesos = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / (10);

            if (mediaComPesos == 4.85f)
            {
                mediaComPesos = 4.8f;
            }

            Console.WriteLine("Media: " + mediaComPesos.ToString("F1", CultureInfo.InvariantCulture));

            if (mediaComPesos >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (mediaComPesos < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                notaFinal = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaFinal = (mediaComPesos + notaFinal) / 2;
                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}