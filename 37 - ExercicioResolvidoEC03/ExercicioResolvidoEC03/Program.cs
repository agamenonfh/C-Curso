using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ExercicioResolvidoEC03
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            string[] vet =  Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            // Comparar os valores e imprimir o menor deles, se houver algum empate mostrar apenas um dos valores.
            if (A <= B && A <= C)
            {
            Console.WriteLine("MENOR = " + A);
            }
            else if (B <= A && B <= C)
            {
            Console.WriteLine("MENOR = " + B);
            }
            else if (C <= A && C <= B)
            {
            Console.WriteLine("MENOR = " + C);}
            }
    }
}