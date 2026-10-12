using System;
using System.Globalization;

namespace ParesEntre5NumerosURI1065
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int count = 0;
            if (a % 2 == 0)
            {
                count = count + 1;

            }
            if (b % 2 == 0)
            {
                count = count + 1;

            }
            if (c % 2 == 0)
            {
                count = count + 1;

            }
            if (d % 2 == 0)
            {
                count = count + 1;

            }
            if (e % 2 == 0)
            {
                count = count + 1;

            }

            Console.WriteLine(count + " valores pares");

        }
    }
}