using System;
using System.Globalization;

namespace ParesImparesPositivosNegativosURI1066
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

            int countPar = 0;
            int countImpar = 0;
            int countPositivo = 0;
            int countNegativo = 0;
            if (a % 2 == 0)
            {
                countPar = countPar + 1;
            }
            else
            {
                countImpar = countImpar + 1;
               
            }
            if (a > 0)
            {
                countPositivo = countPositivo + 1;
            }
            else if (a < 0)
            {
                countNegativo = countNegativo + 1;
            }


            if (b % 2 == 0)
            {
                countPar = countPar + 1;
            }
            else
            {
                countImpar = countImpar + 1;
               
            }
            if (b > 0)
            {
                countPositivo = countPositivo + 1;
            }
            else if (b < 0)
            {
                countNegativo = countNegativo + 1;
            }

            if (c % 2 == 0)
            {
                countPar = countPar + 1;
            }
            else
            {
                countImpar = countImpar + 1;
                
            }
            if (c > 0)
            {
                countPositivo = countPositivo + 1;
            }
            else if (c < 0)
            {
                countNegativo = countNegativo + 1;
            }

            if (d % 2 == 0)
            {
                countPar = countPar + 1;
            }
            else
            {
                countImpar = countImpar + 1;
               
            }
            if (d > 0)
            {
                countPositivo = countPositivo + 1;
            }
            else if(d < 0)          
            {
                countNegativo = countNegativo + 1;
            }

            if (e % 2 == 0)
            {
                countPar = countPar + 1;
            }
            else
            {
               countImpar = countImpar + 1;
            }
            if (e > 0)
            {
                countPositivo = countPositivo + 1;
            }
            else if (e < 0)
            {
                countNegativo = countNegativo + 1;
            }



            Console.WriteLine(countPar + " valor(es) par(es)");
            Console.WriteLine(countImpar + " valor(es) impar(es)");
            Console.WriteLine(countPositivo + " valor(es) positivo(s)");
            Console.WriteLine(countNegativo + " valor(es) negativo(s)");

        }
    }
}