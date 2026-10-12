using System;
using System.Globalization;

namespace ParOuImparURI1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int entrada;

            for (int i = 0; i < n; i++)
            {
                entrada = int.Parse(Console.ReadLine());
                if (entrada == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (entrada > 0)
                {
                    if (entrada % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
                else
                {
                    entrada = entrada * -1;
                    if (entrada % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
        }
    }
}