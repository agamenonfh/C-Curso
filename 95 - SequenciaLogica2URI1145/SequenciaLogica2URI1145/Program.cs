using System;
using System.Globalization;

namespace SequenciaLogica2URI1145
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);
            int soma = x;
            if (x > 1 && x < 20 && y < 100000)
            {
                for (int i = 1; i <= y; i++)
                {
                    if (i != soma)
                    {
                        Console.Write(i + " ");                       
                    }
                    else if (i == soma)
                    {
                        Console.WriteLine(i);
                        soma = soma + x;
                    }                  
                }
            }
        }
    }
}