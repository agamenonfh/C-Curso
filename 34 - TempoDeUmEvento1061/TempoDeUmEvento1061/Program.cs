using System;
using System.Globalization;

namespace TempoDeUmEventoURI1061
{
    class Program
    {
        static void Main(string[] args )
        {
            int diaInicio, horaInicio, minutoInicio, segundoInicio;
            int diaFim, horaFim, minutoFim, segundoFim;
            int duracaoTotalSegundos;
            int duracaoDia, duracaoHora, duracaoMinuto, duracaoSegundo;

            //Aqui será inserido o dia de inicio do evento
            string[] valores = Console.ReadLine().Split(' ');
            diaInicio = int.Parse(valores[1]);

            //Nessa linha será inserido a hora de inicio do evento
            string[] horaInicioValores = Console.ReadLine().Split(':');
            horaInicio = int.Parse(horaInicioValores[0]);
            minutoInicio = int.Parse(horaInicioValores[1]);
            segundoInicio = int.Parse(horaInicioValores[2]);

            //Nessa linha será inserido o dia de fim do evento
            string[] valoresFim = Console.ReadLine().Split(' ');
            diaFim = int.Parse(valoresFim[1]);

            //Nessa linha será inserido a hora de fim do evento
            string[] horaFimValores = Console.ReadLine().Split(':');
            horaFim = int.Parse(horaFimValores[0]);
            minutoFim = int.Parse(horaFimValores[1]);
            segundoFim = int.Parse(horaFimValores[2]);

            //Calculando a duração do evento
            duracaoTotalSegundos = (diaFim - diaInicio) * 24 * 3600 + (horaFim - horaInicio) * 3600 + (minutoFim - minutoInicio) * 60 + (segundoFim - segundoInicio);

            Console.WriteLine($"{duracaoTotalSegundos / 86400} dia(s)");
            Console.WriteLine($"{(duracaoTotalSegundos % 86400) / 3600} hora(s)");
            Console.WriteLine($"{(duracaoTotalSegundos % 3600) / 60} minuto(s)");
            Console.WriteLine($"{duracaoTotalSegundos % 60} segundo(s)");

        }
    }
}