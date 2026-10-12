using System;
using System.Globalization;

namespace DividindoXPorYURI1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] val = Console.ReadLine().Split(' ');
                int x = int.Parse(val[0]);
                int y = int.Parse(val[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = (double)x / y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));

                }

            }
        }
    }
}