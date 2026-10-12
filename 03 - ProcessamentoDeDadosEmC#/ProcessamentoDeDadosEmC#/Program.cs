using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Área do trapézio");

            double b, B, h, area;//Quando o código for escrito em 'double' é necessário utilizar o '.0' após o número inserido

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;

            Console.WriteLine(area);
            Console.WriteLine("Exemplo da área do trapézio escrito em 'float'");

            float b1, B1, h1, area1; //Quando o código for escrito em 'float' é necessário utilizar o 'f' após o número inserido

            b1 = 6f;
            B1 = 8f;
            h1 = 5f;

            area1 = (b1 + B1) / 2f * h1;

            Console.WriteLine(area1);

            Console.WriteLine("Exemplo 4");

            int a, c;
            double resultado;

            a = 5;
            c = 2; 


            resultado = (double) a / c;
            Console.WriteLine(resultado);

            Console.WriteLine("Exemplo 5");

            double q;
            int w;

            q = 5.0;
            w = (int) q;
            
            //É necessario informar que a converção forçada para outro formato é o desejável por quem está escrevendo
            //Por essa razão é preciso colocar '(LinguagemDesejada)' antes da alteração que você quer.
            //Caso Contrário será encontrado um erro de compilação em seu projeto.


            Console.WriteLine(w);

            Console.ReadLine();

        }
    }
}