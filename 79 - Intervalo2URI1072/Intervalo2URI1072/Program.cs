using System;
using System.Globalization;

namespace Intervalo2URI1072
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, x, countIn = 0, countOut = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    countIn = countIn + 1;
                }
                else
                {
                    countOut = countOut + 1;
                }
            }
            Console.WriteLine(countIn + " in");
            Console.WriteLine(countOut + " out");
        }
    }
}