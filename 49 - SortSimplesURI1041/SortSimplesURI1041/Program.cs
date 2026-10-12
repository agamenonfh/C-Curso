using System;
using System.Globalization;

namespace SortSimplesURI1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, menor, meio, maior;
            string[] n = Console.ReadLine().Split(' ');
            a = int.Parse(n[0]);
            b = int.Parse(n[1]);
            c = int.Parse(n[2]);

            if (a < b && a < c)
            {
                menor = a;
                if (b < c)
                {
                    meio = b;
                    maior = c;
                }
                else
                {
                    meio = c;
                    maior = b;
                }
            }
            else if (b < c)
            {
                menor = b;
                if (a < c)
                {
                    meio = a;
                    maior = c;
                }
                else
                {
                    meio = c;
                    maior = a;
                }
            }
            else
            {
                menor = c;
                if (a < b)
                {
                    meio = a;
                    maior = b;
                }
                else
                {
                    meio = b;
                    maior = a;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            

        }
    }
}