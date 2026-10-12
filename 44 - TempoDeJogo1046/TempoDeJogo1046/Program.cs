using System;
using System.Globalization;

namespace DuracaoDeJogo1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao1, duracao2;
            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);
            duracao1 = horaFinal - horaInicial;
            duracao2 = 24 - horaInicial + horaFinal;

            if (horaInicial < horaFinal)
            {
                Console.WriteLine("O JOGO DUROU " + duracao1 + " HORA(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU " + duracao2 + " HORA(S)");
            }
           
        }
    }
}