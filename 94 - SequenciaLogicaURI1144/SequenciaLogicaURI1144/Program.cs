using System;
using System.Globalization;

namespace SequenciaLogicaURI1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " " + Math.Pow(i, 2.0) + " " + Math.Pow(i, 3.0));
                Console.WriteLine(i + " " + (Math.Pow(i, 2.0) + 1) + " " + (Math.Pow(i, 3.0) + 1));
            }
        }
    }
}