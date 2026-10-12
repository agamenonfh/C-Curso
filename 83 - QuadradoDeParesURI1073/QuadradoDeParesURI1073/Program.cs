using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace QuadradoDeParesURI1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "^2 = " + Math.Pow(i, 2.0), CultureInfo.InvariantCulture);
                }
            }
        }
    }
}