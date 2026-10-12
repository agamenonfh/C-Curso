using System;
using System.Globalization;

namespace SequenciasCrescentesURI1146
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            do
            {
                for (int i = 1; i <= x; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                x = int.Parse(Console.ReadLine());
            } while (x > 0);

        }
    }
}