using System;
using System.Globalization;

namespace QuadranteURI1115
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] coordenadas = Console.ReadLine().Split(' ');
            x = int.Parse(coordenadas[0]);
            y = int.Parse(coordenadas[1]);

            while (x != 0 || y != 0)
            {

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");                    
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");                    
                }
                coordenadas = Console.ReadLine().Split(' ');
                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
            }
        }
    }
}