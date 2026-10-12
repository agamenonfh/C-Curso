using System;
using System.Globalization;

namespace ImpostoDeRendaURI1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double imposto008, imposto018, imposto028, impostoTotal, renda, resto;
            renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (renda <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (renda > 2000.00 && renda <= 3000.00)
            {
                imposto008 = (renda - 2000.00) * 0.08;
                Console.WriteLine("R$ " + imposto008.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (renda > 3000.00 && renda <= 4500.00)
            {
                resto = renda - 2000.0;
                imposto008 = 999.99 * 0.08;
                imposto018 = (resto - 999.99) * 0.18;
                impostoTotal = imposto008 + imposto018;
                Console.WriteLine("R$ " + impostoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                resto = renda - 2000.0;
                imposto008 = 999.99 * 0.08;
                imposto018 = 1499.99 * 0.18;
                imposto028 = (renda - 4500.00) * 0.28;
                impostoTotal = imposto008 + imposto018 + imposto028;
                Console.WriteLine("R$ " + impostoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}