using System;
using System.Globalization;

namespace CrescenteEDecrescenteURI1113
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            string[] n = Console.ReadLine().Split(' ');
            X = int.Parse(n[0]);
            Y = int.Parse(n[1]);

            while (X != Y)
            {               
                if (X > Y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }

                n = Console.ReadLine().Split(' ');
                X = int.Parse(n[0]);
                Y = int.Parse(n[1]);
            }
        }
    }
}