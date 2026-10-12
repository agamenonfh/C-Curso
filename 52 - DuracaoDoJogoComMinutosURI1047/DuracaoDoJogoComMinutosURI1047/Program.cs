using System;
using System.Globalization;

namespace TempoDeJogoComMinutosURI1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, minutoInicial, horaFinal, minutoFinal, duracaoHoras, duracaoMinutos, duracao;
            string[] x = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(x[0]);
            minutoInicial = int.Parse(x[1]);
            horaFinal = int.Parse(x[2]);
            minutoFinal = int.Parse(x[3]);

            if (horaFinal < horaInicial || horaFinal == horaInicial && minutoFinal < minutoInicial)
            {
                duracaoHoras = (24 - horaInicial + horaFinal - 1) * 60;
                duracaoMinutos = 60 - minutoInicial + minutoFinal;
                duracao = duracaoHoras + duracaoMinutos;
            }
            else if (horaFinal == horaInicial && minutoInicial == minutoFinal)
            {
                duracaoHoras = (24 - horaFinal + horaInicial) * 60;
                duracaoMinutos = 0;
                duracao = duracaoHoras + duracaoMinutos;
            }
            else if (horaFinal == horaInicial && minutoFinal > minutoInicial)
            {
                duracaoHoras = horaInicial - horaFinal;
                duracaoMinutos = minutoFinal - minutoInicial;
                duracao = duracaoHoras + duracaoMinutos;
            }
            else if (horaFinal > horaInicial && minutoFinal < minutoInicial)
            {
                duracaoHoras = (horaFinal - horaInicial - 1) * 60;
                duracaoMinutos = 60 - minutoInicial + minutoFinal;
                duracao = duracaoHoras + duracaoMinutos;
            }
            else
            {
                duracaoHoras = (horaFinal - horaInicial) * 60;
                duracaoMinutos = minutoFinal - minutoInicial;
                duracao = duracaoHoras + duracaoMinutos;
            }

            Console.WriteLine("O JOGO DUROU " + duracao / 60 + " HORA(S) E " + duracao % 60 + " MINUTO(S)");
        }
    }
}