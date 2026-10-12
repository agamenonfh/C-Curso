using System;
using System.Globalization;

namespace MultiplosDe13URI1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int soma = 0, min, max;

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }
            for (int i = 0; min <= max; min++)
            {
                
                if (min % 13 != 0)
                {
                    soma = soma + min;
                }
                
            }
            Console.WriteLine(soma);

        }
    }
}