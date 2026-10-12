using System;
using System.Globalization;

namespace GrenaisURI1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int golInter, golGremio, grenal, inter, gremio, empates, novoGrenal;
            grenal = 0;
            inter = 0;
            gremio = 0;
            empates = 0;
            novoGrenal = 1;

            while (novoGrenal == 1)
            {
                grenal = grenal + 1;
                string[] gol = Console.ReadLine().Split(' ');
                golInter = int.Parse(gol[0]);
                golGremio = int.Parse(gol[1]);

                if (golInter == golGremio)
                {
                    empates = empates + 1;
                }
                else if (golInter < golGremio)
                {
                    gremio = gremio + 1;
                }
                else if (golInter > golGremio)
                {
                    inter = inter + 1;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(grenal + " grenais");
            Console.WriteLine("Inter:" + inter);
            Console.WriteLine("Gremio:" + gremio);
            Console.WriteLine("Empates:" + empates);
            if (inter > gremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (inter < gremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else if (inter == gremio)
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}