using System;
using System.Globalization;

namespace AumentoDeSalario1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, novoSlario;
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (salario <= 400.00)
            {
                
                Console.WriteLine("Novo salario: " + (salario * 1.15).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + (salario * 0.15).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");

            }
            else if (salario <= 800.00)
            {
                
                Console.WriteLine("Novo salario: " + (salario * 1.12).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + (salario * 0.12).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");

            }
            else if (salario <= 1200.00)
            {
                Console.WriteLine("Novo salario: " + (salario * 1.10).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + (salario * 0.10).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario <= 2000.00)
            {
                Console.WriteLine("Novo salario: " + (salario * 1.07).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + (salario * 0.07).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else
            {
                Console.WriteLine("Novo salario: " + (salario * 1.04).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + (salario * 0.04).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}
    