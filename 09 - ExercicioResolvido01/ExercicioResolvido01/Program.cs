using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Numerics;

namespace ExercicioResolvido01
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, area, precoMetroQuadrado, preco;

            //Exercício com textos interativos por opção minha.
            Console.WriteLine("olá, por favor informe a lagura do terreno a ser calculado:");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Muito bem, agora informe o comprimento:");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Qual o valor do metro quadrado desse lugar?");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = largura * comprimento;
            preco = area * precoMetroQuadrado;
            Console.WriteLine("A largura do terreno é " +  largura + " e o comprimento é " + comprimento + " resultando em " + area.ToString("F2"), CultureInfo.InvariantCulture + " metros quadrados.");
            Console.WriteLine("O valor total do terreno é " + preco.ToString("F2"), CultureInfo.InvariantCulture + " reais");

            Console.ReadLine();

        }
    }
}